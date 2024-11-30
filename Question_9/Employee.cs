using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employeelib
{
	public enum DepartmentType
	{
		HumanResources,
		InformationTechnology,
		Finance,
		Operations,
		Sales
	}
    public class Employee : Person
    {
		private static int _Id = 0;
		private double _Salary;
		private string _Designation;
		private DepartmentType _Dept;


		public DepartmentType Dept
		{
			get { return _Dept; }
			set { _Dept = value; }
		}


		public string Designation
		{
			get { return _Designation; }
			set { _Designation = value; }
		}


		public double Salary
		{
			get { return _Salary; }
			set { _Salary = value; }
		}

		public int Id
		{
			get { return _Id; }
			set { _Id = value; }
		}

        public Employee()
        {
            _Id++;
        }
        public Employee(string name, char gender, Date birth, string address , double salary , string designation , DepartmentType dept):base(name, gender, birth, address)
        {
            _Id++;
			_Salary = salary;
			_Designation = designation;
			_Dept = dept;
        }

		public override void AcceptDetails()
		{
			base.AcceptDetails();
			Console.WriteLine("Enter the Id : ");
			_Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salary : ");
			_Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Designation : ");
			_Designation = Console.ReadLine();
            Console.WriteLine("Enter the Department Type : (0:HR , 1:IT , 2:Finance , 3:Operations , 4:Sales)");
			_Dept = (DepartmentType)Convert.ToInt16(Console.ReadLine());

        }

		public override void PrintDetails()
		{
			base .PrintDetails();
			Console.WriteLine("Id : " + Id);
			Console.WriteLine("Salary : "+Salary);
            Console.WriteLine("Designation : "+Designation);
            Console.WriteLine("Department Type : "+Dept);
		}

        public override string ToString()
        {
            return base.ToString() +"Id : "+Id+" Salary : "+Salary+" Designation : "+Designation+" Department Type : "+Dept+" .";
        }
    }
}
