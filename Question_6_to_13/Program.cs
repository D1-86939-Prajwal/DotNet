using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{

    #region Enum for DepartmentType
    public enum DepartmentType
    {
        HR, IT, Finance, Marketing, Operations
    }
    #endregion

    #region Date Class
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            day = 0;
            month = 0;
            year = 0;
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void AcceptDate()
        {
            Console.Write("Enter Day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine("Day   : " + day);
            Console.WriteLine("Month : " + month);
            Console.WriteLine("Year  : " + year);
        }

        public bool IsValid()
        {
            int[] monthDays = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (year > 0)
            {
                if (month > 0 && month < 13)
                {
                    if (day > 0 && day <= monthDays[month])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            return "Date [" + day + "," + month + "," + year + "]";
        }

        public static int operator -(Date d1, Date d2)
        {
            return d1.year - d2.year;
        }

    }

    #endregion

    #region Person Class
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool gender;
        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private Date birth;
        public Date Birth
        {
            get { return birth; }
            set { birth = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private readonly int age;
        public int Age
        {
            get { return age; }
        }


        public Person()
        {
            name = "";
            birth = new Date();
        }

        public Person(string name, bool gender, int age, string address)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.address = address;
        }

        public virtual void Accept()
        {
            Console.Write("Enter Name  : ");
            name = Console.ReadLine();
            Console.Write("Enter Gender(true:M/false:F): ");
            gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("\nEnter Birthdate  : ");
            birth.AcceptDate();
            Console.Write("Enter Address  : ");
            address = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Name          : " + name);
            Console.WriteLine("Gender (true:M/false:F): " + gender);
            Console.WriteLine("Birthdate     : " + birth);
            //Console.WriteLine("Age           : " + age);
            Console.WriteLine("Address       : " + address);
        }

        public override string ToString()
        {
            return "Person [" + name + "," + gender + "," + birth + "," + address + "]";
        }
    }
    #endregion

    #region Employee Class

    public class Employee : Person
    {
        private readonly int id;
        public int Id
        {
            get { return id; }
        }

        private double salary;
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private string designation;
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        private DepartmentType dept;
        public DepartmentType Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        private static int count = 0;

        public Employee()
        {
            id = count++;

        }

        public Employee(double salary, DepartmentType dept)
        {
            this.id = count++;
            this.salary = salary;
            this.dept = dept;
        }

        public override void Accept()
        {
            base.Accept();
            Console.Write("Enter Employee Salary : ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nSelect Department from following: ");

            foreach (string s in Enum.GetNames(typeof(DepartmentType)))
                Console.WriteLine(s);

            Console.Write("Enter Department     : ");
            Enum.TryParse(Console.ReadLine(), out dept);
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("ID           : " + id);
            Console.WriteLine("Salary       : " + salary);
            Console.WriteLine("Designation  : " + designation);
            Console.WriteLine("Department   : " + dept);
        }

        public override string ToString()
        {
            return "Employee [" + base.ToString() + ", " + id + ", " + salary + ", " + designation + ", " + dept + "]";
        }
    }

    #endregion

    #region Manager Class

    public class Manager : Employee
    {
        private double bonus;
        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public Manager()
        {
            Designation = "Manager";
        }

        public Manager(double bonus)
        {
            Designation = "Manager";
            this.bonus = bonus;
        }

        public override void Accept()
        {
            Console.WriteLine("\nEnter Manager Details");
            base.Accept();
            Console.Write("Enter Bonus      : ");
            bonus = Convert.ToDouble(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Bonus        : " + bonus);
        }

        public override string ToString()
        {
            return "Manager [ " + base.ToString() + ", Bonus: " + bonus + "]";
        }
    }
    #endregion

    #region Supervisor Class

    public class Supervisor : Employee
    {
        private int subbordinate;
        public int Subbordinate
        {
            get { return subbordinate; }
            set { subbordinate = value; }
        }

        public Supervisor()
        {
            Designation = "Supervisor";
        }

        public Supervisor(int subbordinate)
        {
            Designation = "Supervisor";
            this.subbordinate = subbordinate;
        }

        public override void Accept()
        {
            Console.WriteLine("\nEnter Supervisor Details:");
            base.Accept();
            Console.Write("Enter No. of Subordinates: ");
            subbordinate = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("No. of Subordinates: " + subbordinate);
        }

        public override string ToString()
        {
            return "Supervisor [" + base.ToString() + ", Subordinate No.: " + subbordinate + "]";
        }
    }
    #endregion

    #region WageEmp Class

    public class WageEmp : Employee
    {
        private int hour;
        private int rate;

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        public WageEmp()
        {
            base.Designation = "Wage";
        }

        public WageEmp(int hour, int rate)
        {
            this.hour = hour;
            this.rate = rate;
            this.Designation = "Wage";
        }

        public override void Accept()
        {
            Console.WriteLine("\nEnter WageEmp Details:");
            base.Accept();
            Console.Write("Enter Hours Worked   : ");
            hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate/Hour  : ");
            rate = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Hours Worked     : " + hour);
            Console.WriteLine("Rate/Hour        : " + rate);
        }

        public override string ToString()
        {
            return "WageEmp [" + base.ToString() + ", Hour: " + hour + ", Rate: " + rate + "]";
        }
    }

    #endregion


    #region Company Class

    public class Company
    {
        private string cName;
        private string address;
        private double salaryExpense;
        private LinkedList<Employee> empList;

        public LinkedList<Employee> EmpList
        {
            get { return empList; }
            set { empList = value; }
        }

        public double SalaryExpense
        {
            get { return salaryExpense; }
            set { salaryExpense = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string CName
        {
            get { return cName; }
            set { cName = value; }
        }
        public Company()
        {
            cName = "";
            empList = new LinkedList<Employee>();
        }

        public Company(string cName, string address, double salaryExpense)
        {
            empList = new LinkedList<Employee>();
            this.cName = cName;
            this.address = address;
            this.salaryExpense = salaryExpense;
        }

        public void Accept()
        {
            Console.Write("Enter Company Name   : ");
            cName = Console.ReadLine();
            Console.Write("Enter Address        : ");
            address = Console.ReadLine();
            Console.Write("Enter SalaryExp  : ");
            salaryExpense = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("\nCompany Details:");
            Console.WriteLine("Company Name     : " + cName);
            Console.WriteLine("Company Address  : " + address);
            Console.WriteLine("Salary Expense   : " + salaryExpense);
        }

        public double CalculateSalaryExpense() { return salaryExpense; }

        public void AddEmployee(Employee emp)
        {
            empList.AddFirst(emp);
        }

        public LinkedListNode<Employee> FindEmployee(int id)
        {
            if (empList.Count == 0) return null;
            else if (empList.First.Value.Id == id) return empList.First;

            LinkedListNode<Employee> trav = EmpList.First;

            while (trav.Next != null)
            {
                trav = trav.Next;
                if (trav.Value.Id == id)
                {
                    return trav;
                }
            }
            return null;
        }

        public bool RemoveEmployee(int id)
        {
            return empList.Remove(FindEmployee(id).Value);
        }

        public override string ToString()
        {
            return "Company [Name: " + cName + ", Address: " + address + ", SalaryExpense: " + salaryExpense + "]";
        }

        public void PrintEmployees()
        {
            Console.WriteLine("\n**********Employee List********** ");
            foreach (Employee emp in empList)
            {
                emp.Print();
                Console.WriteLine();
            }
        }
    }

    #endregion

}
