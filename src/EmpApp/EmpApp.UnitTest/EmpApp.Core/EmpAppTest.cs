using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EmpApp.Core.Entities;
using EmpApp.Core.Services;
using Moq;

namespace EmpApp.UnitTest.EmpApp.Core
{
    [TestFixture]
    class when_working_with_the_EmpApp
    {
        protected Mock<IEmpPersonalDetails> moqPersonalDetails;
        [SetUp]
        public void setting_the_mock_employee_personal_details()
        {
            moqPersonalDetails = new Mock<IEmpPersonalDetails>();
        }
    }

    class and_performing_some_unit_test : when_working_with_the_EmpApp
    {
        [Test]
        public void like_contribution_to_Pf_returned_by_employee_old_traditional_way()
        {
            //Arrange
            var pfDetails = new EmpPfDetails(new EmpPersonalDetails());

            //Act
            float contribution = pfDetails.GetPfEmployerControlSoFar(1);

            //Assert
            Assert.That(contribution, Is.EqualTo(3456), "No they are not equal");

        }

        [Test]
        public void like_verifying_the_Moq_object()
        {
            
            var pfDetails = new EmpPfDetails(moqPersonalDetails.Object);

            pfDetails.GetPfEmployerControlSoFar(It.IsAny<int>());

            moqPersonalDetails.Verify();
        }

        [Test]
        public void like_Pf_eligibility_for_an_employee_returns_true_for_valid_input()
        {
            var pfDetails = new EmpPfDetails(moqPersonalDetails.Object);
            moqPersonalDetails.Setup(x => x.GetEmployeeSalary(It.IsAny<int>())).Returns(5000);

            var isEligible = pfDetails.IsPfEligible(It.IsAny<int>());

            Assert.IsTrue(isEligible, "Should be true");
        }

        [Test]
        public void like_employee_personal_details_is_called_exactly_once_in_Pf_details_method()
        {
            var pfDetails = new EmpPfDetails(moqPersonalDetails.Object);

            pfDetails.IsPfEligible(It.IsAny<int>());
            moqPersonalDetails.Verify(x => x.GetEmployeeSalary(It.IsAny<int>()), Times.Exactly(1));
        }

        [Test]
        public void like_correct_parameter_is_being_passed_in_eligibility()
        {
            var pfDetails = new EmpPfDetails(moqPersonalDetails.Object);
            
            pfDetails.IsPfEligible(2);

            moqPersonalDetails.Verify(x => x.GetEmployeeSalary(It.Is<int>(i => i == 2)));
        }

        [Test]
        public void like_correct_values_in_property_are_get_and_set()
        {
            var pfDetails = new EmpPfDetails(moqPersonalDetails.Object);
            moqPersonalDetails.Setup(x => x.GetDurationWorked(It.IsAny<int>())).Returns(9);
            moqPersonalDetails.Setup(x => x.Eligibility).Returns(It.IsAny<bool>());

            pfDetails.EmployeeGeneralEligibility(It.IsAny<int>());

            moqPersonalDetails.VerifySet(x => x.Eligibility = false);
            moqPersonalDetails.VerifyGet(x => x.Eligibility);
        }

        [Test]
        public void stubbing_the_property_in_moq_object()
        {
            var pfDetails = new EmpPfDetails(moqPersonalDetails.Object);

            
            // moqPersonalDetails.Object.Eligibility = true;    This wont work. It value will not be set
            moqPersonalDetails.SetupProperty(x => x.Eligibility, true);

            pfDetails.EmployeeGeneralEligibility(It.IsAny<int>());

        }

        [Test]
        public void strict_Loose_mock_behaviour_test()
        {
            var pfDetails = new EmpPfDetails(moqPersonalDetails.Object);
            moqPersonalDetails.Setup(x => x.GetEmployeeSalary(It.IsAny<int>())).Returns(4000);
            moqPersonalDetails.Setup(x => x.GetDurationWorked(It.IsAny<int>())).Returns(20);

            pfDetails.GetPfEmployerControlSoFar(It.IsAny<int>());


        }
    }
}
