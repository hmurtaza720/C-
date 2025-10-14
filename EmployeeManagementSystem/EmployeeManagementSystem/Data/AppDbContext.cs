using EmployeeManagementSystem.Entity;
using Microsoft.EntityFrameworkCore;    

namespace EmployeeManagementSystem.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Set default schema for all tables
            modelBuilder.HasDefaultSchema("m");
        }
    }
}
