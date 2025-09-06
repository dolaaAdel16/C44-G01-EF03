using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public int? Age { get; set; }
        public DateTime HiringDate { get; set; } = DateTime.UtcNow;

        public int DeptId { get; set; }  
        public Department WorkFor { get; set; }
    }
}
