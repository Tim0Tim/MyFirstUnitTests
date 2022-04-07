using System;

namespace Calc
{
    public class Calculator
    {
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
        }
      
       
       // static void Main()
       // {
       //     Console.WriteLine($"{TT}");
       // }
        
    } 
}
//stuff to make a change, sure why not.

//  static void Main()
//  {
//      int x;
//      int y;
//      int T;

//      Console.WriteLine("Please input the first number...");
//      x = int.Parse(Console.ReadLine());
//      Console.WriteLine("Please input the second number...");
//      y = int.Parse(Console.ReadLine());
//      Console.WriteLine("Would you like to divide (1), multiply (2), add (3), or subtract (4)");
//      T = int.Parse(Console.ReadLine());

//  if(T == 1)
//  {
//      Divide = return x / y;
//  }



//    }