using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeelib
{
    public class WageEmp : Employee
    {
		private int _Hours;
		private int _Rate;

		public int Rate
		{
			get { return _Rate; }
			set { _Rate = value; }
		}


		public int Hours
		{
			get { return _Hours; }
			set { _Hours = value; }
		}

        public WageEmp()
        {
            
        }

        public WageEmp(string name, char gender, Date birth, string address, double salary, string designation, DepartmentType dept , int hours , int rate) : base(name, gender, birth, address, salary, "Wage", dept)
        {
			_Hours = hours;
			_Rate = rate;
        }

        public override void AcceptDetails()
        {
            base.AcceptDetails();
            Console.WriteLine("Enter the hours : ");
            Hours = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the rate per hour : ");
            Rate = Convert.ToInt16(Console.ReadLine());
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Hours : " + Hours);
            Console.WriteLine("Rate : "+Rate);
        }
        public override string ToString()
        {
            return base.ToString() + "Hours : "+Hours+" Rate : "+Rate+" .";
        }


    }
}
