using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Employeelib
{
    public class Date
    {
		private int _Day;
		private int _Month;
		private int _Year;

		public int Year
		{
			get { return _Year; }
			set { _Year = value; }
		}


		public int Month
		{
			get { return _Month; }
			set { _Month = value; }
		}


		public int Day
		{
			get { return _Day; }
			set { _Day = value; }
		}

        public Date()
        {
            
        }

        public Date(int day , int month , int year)
        {
            _Day = day;
			_Month = month;
			_Year = year;
        }

		public  void AcceptDate()
		{
            Console.WriteLine("Enter the Day : ");
			_Day = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the month : ");
			_Month = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the Year : ");
			_Year = Convert.ToInt32(Console.ReadLine());
		}

		public void PrintDate()
		{
			Console.WriteLine(_Day+"/"+_Month+"/"+_Year);
		}

		public bool IsValidDate()
		{
			if(_Day > 0 && _Day <= 31 && _Month > 0 && _Month <= 12 && _Year > 1900 && _Year <= 2006) 
			{
				return true;
			}
			return false;
		}

		public override string ToString()
		{
			return "Date : " + Day + "/" + Month + "/" + Year ;
		}

		public static int operator -(Date date)
		{
			return date.Year - DateTime.Now.Year;
		}
    }
}
