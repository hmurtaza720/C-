using EMS_API_Murtaza.Models;
using EMS_API_Murtaza.Mappings;
using Microsoft.EntityFrameworkCore;
using AspNetCoreRateLimit;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// ✅ Serilog configuration
Log.Logger = new LoggerConfiguration()
    .WriteTo.File("Logs/ems_api_log.txt", rollingInterval: RollingInterval.Day)
    .WriteTo.Console()
    .CreateLogger();

builder.Host.UseSerilog();

// ✅ Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ Add DB context
builder.Services.AddDbContext<EMSContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Add AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// ✅ Add Caching
builder.Services.AddMemoryCache();

// ✅ Add Rate Limiting
builder.Services.Configure<IpRateLimitOptions>(options =>
{
    options.GeneralRules = new List<RateLimitRule>
    {
        new RateLimitRule
        {
            Endpoint = "*",
            Limit = 3, // max 5 requests
            Period = "60s" // in 10 seconds
        }
    };
});
builder.Services.AddInMemoryRateLimiting();
builder.Services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
        
var app = builder.Build();

// ✅ Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseIpRateLimiting(); // Apply rate limiting
app.MapControllers();

app.Run();
