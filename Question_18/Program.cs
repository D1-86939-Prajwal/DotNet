using System;

namespace MathDelegateExample
{
    public static class StaticMath
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine("Subtract: " + (a - b));
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine("Multiply: " + (a * b));
        }

        public static void Divide(int a, int b)
        {
            if (b != 0)
                Console.WriteLine("Divide: " + (a / b));
            else
                Console.WriteLine("Cannot divide by zero");
        }
    }

    public class InstanceMath
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine("Subtract: " + (a - b));
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiply: " + (a * b));
        }

        public void Divide(int a, int b)
        {
            if (b != 0)
                Console.WriteLine("Divide: " + (a / b));
            else
                Console.WriteLine("Cannot divide by zero");
        }
    }

    public delegate void MathOperation(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
          
            MathOperation op;
            op = new MathOperation(StaticMath.Sum);
            op(10, 5);

            op = new MathOperation(StaticMath.Subtract);
            op(10, 5);

            op = new MathOperation(StaticMath.Multiply);
            op(10, 5);

            op = new MathOperation(StaticMath.Divide);
            op(10, 5);

        
            InstanceMath instanceMath = new InstanceMath();

            MathOperation instOp;
            instOp = new MathOperation(instanceMath.Sum);
            instOp(20, 4);

            instOp = new MathOperation(instanceMath.Subtract);
            instOp(20, 4);

            instOp = new MathOperation(instanceMath.Multiply);
            instOp(20, 4);

            instOp = new MathOperation(instanceMath.Divide);
            instOp(20, 4);
        }
    }
}
