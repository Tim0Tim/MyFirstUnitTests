using System;

namespace Calc
{
    public class Calculator
    {
        
        public static int Main()
        {
            var calc = new Calculator();
            int x;
            int y;
            int T;

            Console.WriteLine("Please input the first number...");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the second number...");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Would you like to divide (1), multiply (2), add (3), subtract (4), or raise to the power[of second integer] (5)");
            T = int.Parse(Console.ReadLine());

            if (T == 1)
            {
                return calc.Divide(x, y);
            }
            else if (T == 2)
            {
                return calc.Multiply(x,y);
            }
            else if (T == 3)
            {
                return calc.Add(x,y);
            }
            else if (T == 4)
            {
                return calc.Subtract(x, y);
            }
            else if (T == 5)
            {
                return calc.Power(x, y);
            }
            else
            {
                Console.WriteLine("Invalid Input");
                
            }
            return 0;
        }
            //int TT;

        public int Add(int x, int y)
        {
            return x + y;
        }
        
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }
        public int Power(int x, int y)
        {
            double B = Math.Pow(x, y);
            int z = Convert.ToInt32(B);
            //int z = B;
            return z;
        }
    } 
}
/* Console.WriteLine("X  +-/*  Y");
            Console.WriteLine("what is the first integer? (X)");
            x = int.Parse(Console.ReadLine());
            Console.Write($"{x}");
            Console.WriteLine("what is the second integer? (Y)");
            y = int.Parse(Console.ReadLine());
            Console.Write($"{y}");

            Console.WriteLine("What math function?\n(multiply = *)\n(divide = /)\n(Add = +)\n(Subtract = -)");
*/