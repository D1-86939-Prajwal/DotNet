using System;
using System.Collections.Generic;

namespace CompanyEventExample
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    public class Company
    {
        public delegate void EmpListChangedHandler();
        public event EmpListChangedHandler EmpListChanged;

        private List<Employee> employees = new List<Employee>();
        private int totalSalaryExpense = 0;

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            totalSalaryExpense += employee.Salary;
            EmpListChanged?.Invoke();
        }

        public bool RemoveEmployee(Employee employee)
        {
            if (employees.Remove(employee))
            {
                totalSalaryExpense -= employee.Salary;
                EmpListChanged?.Invoke();
                return true;
            }
            return false;
        }

        public void PrintSalaryExpense()
        {
            Console.WriteLine("Total Salary Expense: " + totalSalaryExpense);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.EmpListChanged += Company_EmpListChanged;

            Employee emp1 = new Employee("John", 5000);
            Employee emp2 = new Employee("Sarah", 6000);

            company.AddEmployee(emp1);
            company.AddEmployee(emp2);
            company.RemoveEmployee(emp1);
        }

        private static void Company_EmpListChanged()
        {
            Console.WriteLine("Salary expense updated.");
        }
    }
}
