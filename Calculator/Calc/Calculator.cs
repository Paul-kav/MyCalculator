using System;
using System.Linq;

namespace MyCalculator.Calc
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public void RunCalculation()
        {
            //declaring our variables
            string[] allowedOper = new string[4] { "+", "-", "*", "/" };
            string type;
            int num1;
            int num2;
            int answer;
            string restartCheck;

            //Get the operator type
            Console.WriteLine("What type of calculation do you want to perform? (+, -, *, /)");
            type = GetCalcType(allowedOper);

            //we get the first number
            Console.WriteLine("Write your first number.");
            num1 = GetCalcNum();

            // we get the second number
            Console.WriteLine("Write the second number. ");
            num2 = GetCalcNum();

            //Running the calculation
            answer = Calculate(num1, num2, type);

            //write out the answer
            Console.WriteLine("The answer is " + answer + "\r\n Write 'yes' to restart application.");

            //check if the user wants to restart the app
            restartCheck = Console.ReadLine();
            if (restartCheck == "yes")
            {
                RunCalculation();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private string GetCalcType(string[] allowedOper)
        {
            //we get the operation
            string type = Console.ReadLine();

            //check if operator selected is valid
            while (!allowedOper.Contains(type))
            {
                Console.WriteLine("Choose a valid operator typeQ!");
                type = Console.ReadLine();
            }
            return type;
        }
    }
}
