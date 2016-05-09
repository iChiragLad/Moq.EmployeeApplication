using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using EmpApp.Core.Services;
using EmpApp.Core.Entities;

namespace EmpApp.ConsoleClient
{
    class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<IEmpPersonalDetails>().To<EmpPersonalDetails>();
            Bind<IEmpPfDetails>().To<EmpPfDetails>();
            Bind<IEmpBenifits>().To<EmpBenifits>();
        }
    }
}
