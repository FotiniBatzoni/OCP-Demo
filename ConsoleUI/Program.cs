
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

            var employees = Employees.Create(applicants);

            string employeeInfo = Employees.Display(employees);
            Console.WriteLine(employeeInfo);
            Console.ReadLine();


        }
    }
}
