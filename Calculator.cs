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
                Console.WriteLine($"\n Awnser = {calc.Divide(x, y)}");
            }
            else if (T == 2)
            {
                Console.WriteLine($"\n Awnser = {calc.Multiply(x, y)}");
            }
            else if (T == 3)
            {
                Console.WriteLine($"\n Awnser = {calc.Add(x, y)}");
            }
            else if (T == 4)
            {
                Console.WriteLine($"\n Awnser = {calc.Subtract(x, y)}");
            }
            else if (T == 5)
            {
                Console.WriteLine($"\n Awnser = {calc.Power(x, y)}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
                
            }
            return 0;
        }

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
            return z;
        }
    } 
}