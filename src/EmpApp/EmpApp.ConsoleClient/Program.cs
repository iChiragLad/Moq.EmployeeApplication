using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpApp.Core.Entities;
using EmpApp.Core.Services;
using Ninject;

namespace EmpApp.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID : ");
            int empId = Convert.ToInt32(Console.ReadLine());

            IKernel kernel = new StandardKernel(new NinjectRegistration());

            //Employee Personal Details
            var personalDetails = kernel.Get<IEmpPersonalDetails>();
            Console.WriteLine("Total duration worked by employee -{0} : {1}", personalDetails.GetEmployeeDetails(empId).Name, personalDetails.GetDurationWorked(empId));

            //Employee PF Details
            EmpPfDetails pfDetails = new EmpPfDetails(personalDetails);
            Console.WriteLine("PF contribution for employee -{0} : {1}", personalDetails.GetEmployeeDetails(empId).Name, pfDetails.GetPfEmployerControlSoFar(empId));

            //Employee Benifits
            EmpBenifits empBenifits = new EmpBenifits(personalDetails);
            Console.WriteLine("For employee -{0} -->", personalDetails.GetEmployeeDetails(empId).Name);
            StringBuilder basic = new StringBuilder();
            basic.Append("Basic benifits : {");
            foreach(string s in empBenifits.GetBasicBenifits(empId))
            {
                basic.Append(s + ", ");
            }
            basic.Append("}");
            Console.WriteLine(basic);

            StringBuilder additional = new StringBuilder();
            additional.Append("Additional benifits : {");
            foreach (string s in empBenifits.GetAdditionalBenifits(empId))
            {
                additional.Append(s + ", ");
            }
            additional.Append("}");
            Console.WriteLine(additional);


            Console.ReadKey();

        }
    }
}
