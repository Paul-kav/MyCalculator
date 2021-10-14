using System;
using MyCalculator.Calc;

namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of calculation do you want to perform? (*, +, -)");
            Console.ReadLine();
            Console.WriteLine("Write the first number");
            Console.ReadLine();
            int result = Calculator.Add(10, 100);
           // Console.WriteLine(result);
        }
    }
}
