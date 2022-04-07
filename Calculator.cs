using System;

namespace Calc
{
    public class Calculator
    {
        public Calculator()
        {
            //testing
        }
        static int TT;
        static int stuff;
        public int Add(int x, int y)
        {
            TT = x + y;
            return x + y;
        }
        static void Main()
        {
            Console.WriteLine($"{TT}");
        }
        
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