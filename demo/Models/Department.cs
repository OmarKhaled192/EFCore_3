using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly CreationDate { get; set; }

        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
