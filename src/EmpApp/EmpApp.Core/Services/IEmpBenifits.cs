using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp.Core.Services
{
    public interface IEmpBenifits
    {
        List<string> GetBasicBenifits(int empId);
        List<string> GetAdditionalBenifits(int empId);
    }
}
