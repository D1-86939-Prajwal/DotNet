using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{

    public struct Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Std
        {
            get { return std; }
            set { std = value; }
        }

        public char Div
        {
            get { return div; }
            set { div = value; }
        }


        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter gender");
            Gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter age");
            Age = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter std");
            Std =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter div");
            Div = Convert.ToChar( Console.ReadLine());
            Console.WriteLine("Enter marks");
            Marks = Convert.ToDouble(Console.ReadLine());
        }
        public void PrintDetails()
        {
            Console.WriteLine("Name : " + Name);
            if(Gender == true)
            {
                Console.WriteLine("Gender : Male");
            }
            else
            {
                Console.WriteLine("Gender : Female");
            }
       
            Console.WriteLine("Age : " +  Age);
            Console.WriteLine("Std : " + Std);
            Console.WriteLine("Div : " + Div);
            Console.WriteLine("Makrs : " + Marks);

        }

     }
        internal class Program
        {
            static void Main(string[] args)
            {
            Student student = new Student();
            student.AcceptDetails();
            student.PrintDetails();

            }
        }
    
}
