using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = Convert.ToInt32(args[0]);
            int y = Convert.ToInt32(args[1]);

            Math math = new Math();

            switch (args[2])
            {
                case "+":
                    Console.WriteLine("Sum of "+ x +" and "+ y +": " + math.add(x, y));
                    break;

                case "-":
                    Console.WriteLine("Difference between "+ x +" and "+ y +": " + math.subtract(x,y));
                    break;

                case "*":
                    Console.WriteLine("Multiplication of "+ x + " and "+y+": "+ math.multiply(x,y));
                    break;

                case "/":
                    Console.WriteLine("Division of "+x+" and "+y+": "+ math.divide(x,y));
                    break;

                default:
                    Console.WriteLine("Invalid Arguments !!!");
                    break;
            }

        }
    }



    public class Math
    {
        public int add(int a, int b) { return a + b; }

        public int subtract(int a, int b) { return a - b; }

        public int multiply(int a, int b) { return (a * b); }

        public double divide(int a, int b)
        {
            if(b == 0) { return -1; }

            return a / b;
        }

    }
}
