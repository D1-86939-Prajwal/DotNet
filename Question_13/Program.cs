using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employeelib;

namespace Question13
{
    public class Program
    {

        static void Main(string[] args)
        {
            Company company = new Company();
            company.AcceptDetails();
            company.PrintDetails();
            company.AddEmployee();
            company.AddEmployee();
            company.PrintDetails();
            company.PrintEmployees();
            Console.WriteLine("Enter the id to search : ");
            int key = Convert.ToInt16(Console.ReadLine());
            company.FindEmployee(key);
            Console.WriteLine(company.CalculateSalaryExpense());



        }
    }
}
