using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Company_System.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<EmployeeTaskModel> EmployeeTasks { get; set; }
        public DbSet<FeedbackModel> Feedback { get; set; }
    }
}
