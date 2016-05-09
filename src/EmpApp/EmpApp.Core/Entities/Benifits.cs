using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp.Core.Entities
{
    public class Benifits
    {
        public int BenifitGrade { get; set; }
        public List<string> BasicBenifits { get; set; }
        public List<string> AdditionalBenifits { get; set; }
    }
}
