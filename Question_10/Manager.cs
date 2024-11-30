using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeelib
{
    public class Manager : Employee
    {
		private double _Bonus;

		public double Bonus
		{
			get { return _Bonus; }
			set { _Bonus = value; }
		}
        public Manager()
        {
            
        }

        public Manager(string name, char gender, Date birth, string address, double salary, string designation, DepartmentType dept , double bonus) : base(name, gender, birth, address, salary, "Manager", dept)
        {
            
            _Bonus = bonus;
        }

        public override void AcceptDetails()
        {
            base.AcceptDetails();
            Console.WriteLine("Enter the Bonus");
            _Bonus = Convert.ToDouble(Console.ReadLine());
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Bonus : "+Bonus);
        }

        public override string ToString()
        {
            return base.ToString() + "Bonus : "+Bonus+" .";
        }



    }
}
