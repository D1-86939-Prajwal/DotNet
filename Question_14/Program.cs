using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question14
{
    internal class Program
    {
        public static int menu()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Accept Company Details");
            Console.WriteLine("2. Add the Employee");
            Console.WriteLine("3. Remove the Employee");
            Console.WriteLine("4. Find the Employee");
            Console.WriteLine("5. Display Company Info");
            Console.WriteLine("6. Display all Employees");
            Console.WriteLine("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }


        static void Main(string[] args)
        {
            Company company = new Company();

            int choice;
            while ((choice = menu()) != 0)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("-----------------------------");
                        company.AcceptDetails();
                        Console.WriteLine("-----------------------------");
                        break;
                    case 2:
                        Console.WriteLine("-----------------------------");
                        company.AddEmployee();
                        Console.WriteLine("-----------------------------");
                        break;
                    case 3:
                        Console.WriteLine("Enter the Id to remove employee : ");
                        int key = Convert.ToInt32(Console.ReadLine());
                        company.RemoveEmployee(key);
                        break;
                    case 4:
                        Console.WriteLine("Enter the id to find the employee : ");
                        int key1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("-----------------------------");
                        company.FindEmployee(key1).PrintDetails();
                        Console.WriteLine("-----------------------------");
                        break;
                    case 5:
                        Console.WriteLine("-----------------------------");
                        company.PrintDetails();
                        Console.WriteLine("-----------------------------");
                        break;
                    case 6:
                        Console.WriteLine("-----------------------------");
                        company.PrintEmployees();
                        Console.WriteLine("-----------------------------");
                        break;
                    default:
                        Console.WriteLine("Enter the valid choice !!!");
                        break ;
                }
            }
        }
    }
}
