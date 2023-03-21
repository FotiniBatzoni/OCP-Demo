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
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey"},
                new PersonModel { FirstName = "Tony", LastName = "Balis"},
                new PersonModel { FirstName = "Melissa", LastName = "Cortney"},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accounProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accounProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} : {emp.LastName} : {emp.EmailAddress} IsManager: {emp.IsManager}");
            }

            Console.ReadLine();
        }
    }
}
