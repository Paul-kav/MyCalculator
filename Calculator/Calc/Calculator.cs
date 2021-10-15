using System;
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
            string[] operations = new string[4] { "+", "-", "*", "/" };
            string type;
            int num1;
            int num2;
            int answer;
            string restartCheck;

            //Get the operator type
            Console.WriteLine("What type of calculation do you want to perform? (+, -, *, /)");
            type = GetCalcType(operations);

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
    }
}
