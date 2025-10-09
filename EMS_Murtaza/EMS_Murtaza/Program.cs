using EMS_Murtaza.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ✅ Add controller and Swagger services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ Add DbContext (read connection string from appsettings.json)
builder.Services.AddDbContext<EMSContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ??
        "Server=172.17.40.11;Database=intern_devdb;User Id=intern;Password=intern@123;TrustServerCertificate=True;MultipleActiveResultSets=True;Trusted_Connection=False"));

var app = builder.Build();

// ✅ Configure the HTTP request pipeline
// ⚠️ This should be inside *if (app.Environment.IsDevelopment())*
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Enable HTTPS + Routing + Controllers
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
