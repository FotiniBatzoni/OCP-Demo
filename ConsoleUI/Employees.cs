using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class Employees
    {
        public static List<EmployeeModel> Create(List<IApplicantModel> applicants)
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            return employees;

        }

        public static string Display(List<EmployeeModel> employees)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var emp in employees)
            {
                sb.AppendLine($"{emp.FirstName} : {emp.LastName} : {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive {emp.IsExecutive}");
            }

            return sb.ToString();
        }
    }


}
