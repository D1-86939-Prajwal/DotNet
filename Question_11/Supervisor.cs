using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeelib
{
    public class Supervisor : Employee
    {
		private int _SubOrdinates;

		public int SubOrdinates
		{
			get { return _SubOrdinates; }
			set { _SubOrdinates = value; }
		}

        public Supervisor()
        {
            
        }

        public Supervisor(string name, char gender, Date birth, string address, double salary, string designation, DepartmentType dept , int subordinates) : base(name, gender, birth, address, salary, "Supervisor", dept)
        {
            _SubOrdinates = subordinates;
        }

        public override void AcceptDetails()
        {
            base.AcceptDetails();
            Console.WriteLine("Enter the number of SubOrdinates : ");
            SubOrdinates = Convert.ToInt32(SubOrdinates);
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("SubOrdinates : "+SubOrdinates);
        }

        public override string ToString()
        {
            return base.ToString() + " SubOrdinates : "+SubOrdinates+" .";
        }

    }
}
