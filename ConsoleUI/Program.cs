
using OCP__Library;
using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey"},
                new ManagerModel { FirstName = "Tony", LastName = "Balis"},
                new ExecutiveModel { FirstName = "Melissa", LastName = "Cortney"},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} : {emp.LastName} : {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
