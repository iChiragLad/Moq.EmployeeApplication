using EmpApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp.Core.Entities
{
    public class EmpPfDetails : IEmpPfDetails
    {
        IEmpPersonalDetails _empPersonalDetails;

        public EmpPfDetails(IEmpPersonalDetails empPersonalDetails)
        {
            _empPersonalDetails = empPersonalDetails;
        }

        public float GetPfEmployerControlSoFar(int empId)
        {

            int duration = _empPersonalDetails.GetDurationWorked(empId);
            float salary = _empPersonalDetails.GetEmployeeSalary(empId);

            var basic = (salary * 30) / 100;
            var contribution = (basic * 12) / 100;

            return contribution * duration;
        }

        public bool IsPfEligible(int empId)
        {
            if(_empPersonalDetails.GetEmployeeSalary(empId) >= 4000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
