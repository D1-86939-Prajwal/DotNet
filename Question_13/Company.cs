using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employeelib;

namespace Question13
{
    public class Company
    {
		private string _Cname;
		private string _Address;
		private double _SalaryExpense;
		private LinkedList<Employee> _EmployeeList;

		public double SalaryExpense
		{
			get { return _SalaryExpense; }
			set { _SalaryExpense = value; }
		}


		public string Address
		{
			get { return _Address; }
			set { _Address = value; }
		}


		public string Cname
		{
			get { return _Cname; }
			set { _Cname = value; }
		}

        public Company()
        {
			_Cname = "Cure All";
			_Address = "Pune";
			_EmployeeList = new LinkedList<Employee>();
        }

        public Company(string cname , string address )
        {
            _Cname= cname;
			_Address = address;
			_EmployeeList = new LinkedList<Employee>();
        }

		public void AcceptDetails()
		{
            Console.WriteLine("Enter the name of Company : ");
			_Cname = Console.ReadLine();

            Console.WriteLine("Enter the address of Company : ");
			_Address = Console.ReadLine();

		}

		public void PrintDetails()
		{
            Console.WriteLine("Company Name : "+_Cname);
            Console.WriteLine("Address : "+_Address);
		}

		public double CalculateSalaryExpense()
		{
			_SalaryExpense = 0;
			foreach (Employee emp in _EmployeeList)
			{
				_SalaryExpense = _SalaryExpense + emp.Salary;
			}

			return _SalaryExpense;

		}

		public void AddEmployee()
		{
			Employee emp = new Employee();
			emp.AcceptDetails();
			_EmployeeList.AddFirst(emp);
		}
		public void RemoveEmployee(int id)
		{
			foreach (Employee emp in _EmployeeList)
			{
				if(emp.Id == id)
				{
					_EmployeeList.Remove(emp);
				}
			}
		}

		public Employee FindEmployee(int id)
		{
			foreach(Employee emp in _EmployeeList)
			{
				if (emp.Id == id)
				{
					return emp;
				}
			}
			return null;
		}



        public override string ToString()
        {
            return "Cname : "+Cname+" Address : "+Address+" .";
        }

		public void PrintEmployees()
		{
			foreach(Employee emp in _EmployeeList)
			{
				emp.PrintDetails();
			}
		}
    }
}
