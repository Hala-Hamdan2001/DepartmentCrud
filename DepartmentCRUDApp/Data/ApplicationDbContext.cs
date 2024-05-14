using DepartmentCRUDApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DepartmentCRUDApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Department> DepartmentSet { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CRUD;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
