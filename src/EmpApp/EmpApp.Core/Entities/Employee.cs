using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp.Core.Entities
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public int DurationWorked { get; set; }
        public int Grade { get; set; }
    }
}
