using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp.Core.Entities
{
    public class EmployeeEntity
    {
        public List<Employee> EmployeeCollection = new List<Employee>()
        {
            new Employee()
            {
                EmpId = 1,
                Name = "Chirag",
                Salary = 4000,
                DurationWorked = 24,
                Grade = 1
            },
            new Employee()
            {
                EmpId = 2,
                Name = "Niraj",
                Salary = 7000,
                DurationWorked = 30,
                Grade = 2
            },
            new Employee()
            {
                EmpId = 3,
                Name = "Noel",
                Salary = 3500,
                DurationWorked = 13,
                Grade = 2
            },
            new Employee()
            {
                EmpId = 4,
                Name = "Chirag",
                Salary = 2500,
                DurationWorked = 18,
                Grade = 3
            }
        };
    }
}
