using EmpApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp.Core.Entities
{
    public class EmpBenifits : IEmpBenifits
    {
        IEmpPersonalDetails _employeePersonalDetails;
        BenifitEntity employeeEntity;

        public EmpBenifits(IEmpPersonalDetails employeePersonalDetails)
        {
            _employeePersonalDetails = employeePersonalDetails;
            employeeEntity = new BenifitEntity();
        }
        public List<string> GetAdditionalBenifits(int empId)
        {
            List<string> abenifits = null;
            int grade = _employeePersonalDetails.GetEmployeeGrade(empId);
            foreach(Benifits b in employeeEntity.BenifitCollection)
            {
                if(b.BenifitGrade == grade)
                {
                    abenifits = b.AdditionalBenifits;
                }
            }

            return abenifits;
        }

        public List<string> GetBasicBenifits(int empId)
        {
            List<string> benifits = null;
            int grade = _employeePersonalDetails.GetEmployeeGrade(empId);
            foreach (Benifits b in employeeEntity.BenifitCollection)
            {
                if (b.BenifitGrade == grade)
                {
                    benifits = b.BasicBenifits;
                }
            }

            return benifits;
        }
    }
}
