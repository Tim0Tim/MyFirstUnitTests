using System;

namespace Calc
{
    public class Calculator
    {
        public static void Main()
        {
            Console.WriteLine("Hello");
        }
        //int TT;
        int x;
        int y;
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

        public Calculator()
        {
            Console.WriteLine("X  +-/*  Y");
            Console.WriteLine("what is the first integer? (X)");
            x = int.Parse(Console.ReadLine());
            Console.Write($"{x}");
            Console.WriteLine("what is the second integer? (Y)");
            y = int.Parse(Console.ReadLine());
            Console.Write($"{y}");

            Console.WriteLine("What math function?\n(multiply = *)\n(divide = /)\n(Add = +)\n(Subtract = -)");
        }


    } 
}
