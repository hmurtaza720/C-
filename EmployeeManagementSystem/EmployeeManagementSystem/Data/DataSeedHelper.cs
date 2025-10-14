using EmployeeManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EmployeeManagementSystem.Data
{

       public class DataSeedHelper
    {
        private readonly AppDbContext dbContext;
        public DataSeedHelper(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }   
            public void InsertData()
        {
            if (!dbContext.Employees.Any())
            {
                dbContext.Employees.Add(new Entity.Employee { Name = "Murtaza" });

                dbContext.Employees.Add(new Entity.Employee { Name = "Rameez" });
            }
            dbContext.SaveChanges();
        }
    }
}



