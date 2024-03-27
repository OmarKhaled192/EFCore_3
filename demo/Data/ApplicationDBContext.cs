using demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace demo.Data
{
    internal class ApplicationDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
          =>  optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = .; Database = NewCompany; Trusted_Connection = True; TrustServerCertificate = True", options => options.UseDateOnlyTimeOnly());
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; } 
    }
}
