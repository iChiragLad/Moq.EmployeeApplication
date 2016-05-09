using EmpApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp.Core.Services
{
    public interface IEmpPersonalDetails
    {
        float GetEmployeeSalary(int empId);
        void SaveEmployee(Employee employee);
        Employee GetEmployeeDetails(int empId);
        int GetDurationWorked(int empId);
        bool EmployeePfEligibility(IEmpPfDetails pfDetails, int empId);
        int GetEmployeeGrade(int empId);
    }
}
