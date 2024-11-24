using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace StudentArray
{
    internal class Program
    {
        public class Student
        {
            private string name;
            private int id;
            private double marks;

            public Student()
            {
                name = "";
                id = -1;
                marks = -1;
            }

            public Student(string name, int id, double marks)
            {
                this.name = name;
                this.id = id;
                this.marks = marks;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Id
            { get { return id; } set { id = value; } }

            public double Marks { get { return marks; } set { marks = value; } }

            public void AcceptStudent()
            {
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Id: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Marks: ");
                marks = Convert.ToDouble(Console.ReadLine());
            }

            public void DisplayStudent()
            {
                Console.WriteLine("Name  : " + name);
                Console.WriteLine("Id    : " + id);
                Console.WriteLine("Marks : " + marks);
            }

        }

        static Student[] CreateArray(int n)
        {
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                students[i] = new Student();
            }
            return students;
        }

        static void AcceptInfo(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i].AcceptStudent();
            }
        }

        static void PrintInfo(Student[] students)
        {
            Console.WriteLine("Students Details are: \n");

            for (int i = 0; i < students.Length; i++)
            {
                students[i].DisplayStudent();
            }
        }

        static Student[] ReverseArray(Student[] students)
        {
            Student temp = new Student();
            int n = students.Length - 1;
            for (int i = 0; i < n; i++)
            {
                temp = students[i];
                students[i] = students[n - i];
                students[n - i] = temp;
            }
            return students;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the Number of Students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Student[] students = CreateArray(n);
            AcceptInfo(students);
            PrintInfo(students);
            ReverseArray(students);
            Console.WriteLine("\nAfter Reversing the array: \n");
            PrintInfo(students);
            Console.Read();

        }
    }
}
