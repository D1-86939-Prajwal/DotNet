using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace EmployeeLib
{
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void Accept()
        {
            Console.Write("Enter Employee ID: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}");
        }
    }

    [Serializable]
    public class Company
    {
        public ArrayList Employees { get; set; } = new ArrayList();

        public void AddEmployee(Employee emp)
        {
            Employees.Add(emp);
        }

        public void PrintEmployees()
        {
            foreach (Employee emp in Employees)
            {
                emp.Print();
            }
        }

        public void SaveToSoapFile(string filePath)
        {
            SoapFormatter formatter = new SoapFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(fs, this);
            }
            Console.WriteLine("Data saved in SOAP format.");
        }

        public static Company LoadFromSoapFile(string filePath)
        {
            SoapFormatter formatter = new SoapFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (Company)formatter.Deserialize(fs);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            int choice;

            while ((choice = ShowMenu()) != 0)
            {
                switch (choice)
                {
                    case 1:
                        Employee emp = new Employee();
                        emp.Accept();
                        company.AddEmployee(emp);
                        break;

                    case 2:
                        Console.Write("Enter file path to save: ");
                        string savePath = Console.ReadLine();
                        company.SaveToSoapFile(savePath);
                        break;

                    case 3:
                        Console.Write("Enter file path to load: ");
                        string loadPath = Console.ReadLine();
                        company = Company.LoadFromSoapFile(loadPath);
                        Console.WriteLine("Data loaded.");
                        company.PrintEmployees();
                        break;

                    case 4:
                        company.PrintEmployees();
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

            Console.WriteLine("Thanks for using the system.");
        }

        static int ShowMenu()
        {
            Console.WriteLine("\n****** Employee Management ******");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Save Employees to SOAP File");
            Console.WriteLine("3. Load Employees from SOAP File");
            Console.WriteLine("4. Show All Employees");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
