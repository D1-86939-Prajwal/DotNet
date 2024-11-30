using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

[assembly: AssemblyVersion("2.0.0.0")]

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
        public List<Employee> Employees { get; set; } = new List<Employee>();

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

        public void SerializeToFile(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(fs, this);
            }
            Console.WriteLine("Data serialized successfully.");
        }

        public static Company DeserializeFromFile(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
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
                        Console.Write("Enter file path to save data: ");
                        string savePath = Console.ReadLine();
                        company.SerializeToFile(savePath);
                        break;

                    case 3:
                        Console.Write("Enter file path to load data: ");
                        string loadPath = Console.ReadLine();
                        company = Company.DeserializeFromFile(loadPath);
                        Console.WriteLine("Data deserialized successfully.");
                        company.PrintEmployees();
                        break;

                    case 4:
                        company.PrintEmployees();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }

            Console.WriteLine("Thank you for using the Employee Management System.");
        }

        static int ShowMenu()
        {
            Console.WriteLine("\n****** Employee Management System ******");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Serialize Employees to File");
            Console.WriteLine("3. Deserialize Employees from File");
            Console.WriteLine("4. Print All Employees");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
