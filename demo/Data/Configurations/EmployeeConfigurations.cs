using demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Data.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // name prop
            builder.Property(E => E.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasDefaultValue("Cairo");

            // Salary
            builder.Property(E => E.Salary)
                .HasColumnType("decimal(12, 2)");
        }
    }
}
