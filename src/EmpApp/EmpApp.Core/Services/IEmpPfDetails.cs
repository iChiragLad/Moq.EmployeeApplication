using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp.Core.Services
{
    public interface IEmpPfDetails
    {
        bool IsPfEligible(int empId);
        float GetPfEmployerControlSoFar(int empId);
    }
}
