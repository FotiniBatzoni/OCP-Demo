using NUnit.Framework;
using OCP__Library;
using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace ConsoleUI.Test
{
    public class CreateEmployeeTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateEmployees_GivenApplicants_CreatesEmployessWithCorrectData()
        {
            //Arrange
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey"},
                new ManagerModel { FirstName = "Tony", LastName = "Balis"},
                new ExecutiveModel { FirstName = "Melissa", LastName = "Cortney"},
            };

            //Act
            List<EmployeeModel> employees = Employees.Create(applicants);

            // Assert
            Assert.AreEqual(3, employees.Count);
            Assert.AreEqual("Tim", employees[0].FirstName);
            Assert.AreEqual("Corey", employees[0].LastName);
            Assert.AreEqual("Tony", employees[1].FirstName);
            Assert.AreEqual("Balis", employees[1].LastName);
            Assert.AreEqual("Melissa", employees[2].FirstName);
            Assert.AreEqual("Cortney", employees[2].LastName);
            Assert.AreEqual("TCorey@testmail.com", employees[0].EmailAddress);
            Assert.AreEqual("TBalis@testmailcorp.com", employees[1].EmailAddress);
            Assert.AreEqual("MelissaCortney@testmailcorp.com", employees[2].EmailAddress);
            Assert.IsFalse(employees[0].IsManager);
            Assert.IsTrue(employees[1].IsManager);
            Assert.IsTrue(employees[2].IsManager);
            Assert.IsFalse(employees[0].IsExecutive);
            Assert.IsFalse(employees[1].IsExecutive);
            Assert.IsTrue(employees[2].IsExecutive);
        }

        [Test]
        public void DisplayEmployees_GivenApplicants_CreatesEmployessWithCorrectData()
        {
            //Arrange
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey"},
                new ManagerModel { FirstName = "Tony", LastName = "Balis"},
                new ExecutiveModel { FirstName = "Melissa", LastName = "Cortney"},
            };

            //Act
            List<EmployeeModel> employees = Employees.Create(applicants);
            string actual = "Tim : Corey : TCorey@testmail.com IsManager: False IsExecutive False" + Environment.NewLine +
                            "Tony : Balis : TBalis@testmailcorp.com IsManager: True IsExecutive False" + Environment.NewLine +
                            "Melissa : Cortney : MelissaCortney@testmailcorp.com IsManager: True IsExecutive True" + Environment.NewLine;


            string expected = Employees.Display(employees);

            // Assert
           Assert.AreEqual(expected, actual);

        }
    }


}