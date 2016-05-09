using EmpApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp.Core.Entities
{
    public class EmpPersonalDetails : IEmpPersonalDetails
    {
        private readonly EmployeeEntity _employeeEntity;

        public EmpPersonalDetails()
        {
            _employeeEntity = new EmployeeEntity();
        }

        public bool EmployeePfEligibility(IEmpPfDetails pfDetails, int empId)
        {
            if(pfDetails.IsPfEligible(empId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetDurationWorked(int empId)
        {
            int duration = 0;
            foreach (Employee e in _employeeEntity.EmployeeCollection)
            {
                if (e.EmpId == empId)
                {
                    duration = e.DurationWorked;
                }
            }

            return duration;
        }

        public Employee GetEmployeeDetails(int empId)
        {
            Employee emp = null;
            foreach (Employee e in _employeeEntity.EmployeeCollection)
            {
                if (e.EmpId == empId)
                {
                    emp = e;
                }
            }

            return emp;
        }

        public int GetEmployeeGrade(int empId)
        {
            int grade = 0;
            foreach (Employee e in _employeeEntity.EmployeeCollection)
            {
                if (e.EmpId == empId)
                {
                    grade = e.Grade;
                }
            }

            return grade;
        }

        public float GetEmployeeSalary(int empId)
        {
            float salary = 0;
            foreach(Employee e in _employeeEntity.EmployeeCollection)
            {
                if(e.EmpId == empId)
                {
                    salary = e.Salary;
                }
            }

            return salary;
        }

        public void SaveEmployee(Employee employee)
        {
            _employeeEntity.EmployeeCollection.Add(employee);
        }
    }
}
