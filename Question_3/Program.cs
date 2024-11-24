using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practice
{
    internal class Program
    {


        public int add(int x, int y)
        {

            return x + y;
        }

        public int sub(int x, int y)
        {
            return x - y;
        }

        public int mul(int x, int y)
        {
            return x * y;
        }
        public int div(int x, int y)
        {
            return x / y;
        }



        static void Main(string[] args)
        {

            Program program = new Program();
            int choice;
            do
            {

                Console.WriteLine("Calculator");
                Console.WriteLine("1 : Addition");
                Console.WriteLine("2 : Substraction");
                Console.WriteLine("3 : Multiplication");
                Console.WriteLine("4 : Division");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter first number :");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second number :");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Result : " + program.add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("Result : " + program.sub(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Result : " + program.mul(num1, num2));
                        break;

                    case 4:
                        Console.WriteLine("Result : " + program.div(num1, num2));
                        break;
                    case 5:
                        break;

                    default:
                        Console.WriteLine("Invalid Choice  Enter your choice again");
                        break;
                }
            } while (choice != 5);


        }
    }
}
