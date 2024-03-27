using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace demo.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly CreationDate { get; set; }

        // Navigational Property [Many] --> [Related Data]
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }

}
