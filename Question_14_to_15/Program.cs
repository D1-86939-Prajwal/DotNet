using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace EMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt;
            Company company = new Company();
            company.Accept();

            while ((opt = Menu()) != 0)
            {
                switch (opt)
                {
                    case 1:
                        company.AddEmployee(AddEmployee());
                        break;

                    case 2:
                        Console.Write("\nEnter Employee ID: ");
                        if (company.RemoveEmployee(Convert.ToInt32(Console.ReadLine())))
                        {
                            Console.WriteLine("\nEmployee Removed Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Employee Not Found !!!");
                        }
                        break;

                    case 3:
                        Console.Write("\nSearch Employee by ID: ");
                        LinkedListNode<Employee> e = company.FindEmployee(Convert.ToInt32(Console.ReadLine()));
                        if (e != null)
                        {
                            Console.WriteLine("\nEmployee Found:");
                            e.Value.Print();
                        }
                        else
                        {
                            Console.WriteLine("\nEmployee Not Found !!!");
                        }
                        break;

                    case 4:
                        company.Print();
                        break;

                    case 5:
                        company.PrintEmployees();
                        break;

                }
            }

            Console.WriteLine("******************************************");
            Console.WriteLine("Thanks For Visiting :)");

        }


        public static Employee AddEmployee()
        {
            Console.WriteLine("\n1. Add Manager");
            Console.WriteLine("2. Add Supervisor");
            Console.WriteLine("3. Add WageEmployee");
            Console.Write("Enter Choice: ");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Employee manager = new Manager();
                    manager.Accept();
                    return manager;

                case 2:
                    Employee supervisor = new Supervisor();
                    supervisor.Accept();
                    return supervisor;

                case 3:
                    Employee wageEmp = new WageEmp();
                    wageEmp.Accept();
                    return wageEmp;

                default:
                    return null;
            }

        }


        public static int Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("*******Employee Management System*******");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Remove Employee");
            Console.WriteLine("3. Find Employee by ID");
            Console.WriteLine("4. Display Company Info");
            Console.WriteLine("5. Display All Employee");
            Console.Write("Enter Choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
