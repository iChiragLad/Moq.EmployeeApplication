using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp.Core.Entities
{
    public class BenifitEntity
    {
        public List<Benifits> BenifitCollection = new List<Benifits>()
        {
            new Benifits()
            {
                BenifitGrade = 1,
                BasicBenifits = new List<string>() { "Hospital", "Gym", "Dental"},
                AdditionalBenifits = new List<string>() { "Car", "DriverHire", "Holiday" }
            },

            new Benifits()
            {
                BenifitGrade = 2,
                BasicBenifits = new List<string>() { "Hospital", "Gym", "Dental"},
                AdditionalBenifits = new List<string>() { "Car", "DriverHire" }
            },

            new Benifits()
            {
                BenifitGrade = 3,
                BasicBenifits = new List<string>() { "Hospital", "Gym"},
                AdditionalBenifits = new List<string>() { "Car"}
            },

            new Benifits()
            {
                BenifitGrade = 4,
                BasicBenifits = new List<string>() { "Hospital" },
                AdditionalBenifits = new List<string>() { "Car" }
            }
        };
    }
}
