using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public string? Address{ get; set; }
        public decimal? Salary { get; set; }

        //public int DepartmentId { get; set; }

        public Department Department { get; set; } = null!;


    }
}
