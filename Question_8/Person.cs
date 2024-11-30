using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeelib
{
    public class Person
    {
		private string _Name;
		private char _Gender;
		private Date _Birth ;
		private string _Address;

		public string Address
		{
			get { return _Address; }
		}

		public Date Birth	
		{
			get { return _Birth; }
		}


		public char Gender
		{
			get { return _Gender; }
		}


		public string Name
		{
			get { return _Name; }
		}

		public int Age
		{
			get { return DateTime.Now.Year - Birth.Year; }
		}

        public Person()
        {
            _Birth = new Date();
        }

        public Person( string name , char gender , Date birth , string address)
        {
            _Name = name;
			_Gender = gender;
			_Birth = new Date();

			_Address = address;
        }

		public virtual void AcceptDetails()
		{
            Console.WriteLine("Enter the name : ");
			_Name = Console.ReadLine();
            Console.WriteLine("Enter the gender : ");
			_Gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the Date : ");
			_Birth.AcceptDate();
            Console.WriteLine("Enter the Address : ");
			_Address = Console.ReadLine();
		}

		public virtual void PrintDetails()
		{
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("Gender : "+Gender);
            Console.WriteLine("Age : "+Age);
            Console.WriteLine("Address : "+Address);
		}

		public override string ToString()
		{
			return "Name : "+Name+" Gender :"+Gender+" Age :"+Age+" Address"+Address ;
		}
    }
}
