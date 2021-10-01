using System;
using MyCalculator.Calc;

namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Add(10, 100);
            Console.WriteLine(result);
        }
    }
}
