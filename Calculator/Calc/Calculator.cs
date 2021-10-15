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

        private int GetCalcNum()
        {
            int num;
            //checking if the parse is successful
            //returns as a boolean
            bool parseCheck = Int32.TryParse(Console.ReadLine(), out num);

            //As long as the boolean is false, it keeps looping the input
            while (!parseCheck)
            {
                Console.WriteLine("Try again! This time with actual numbers... (-_- *)");
                parseCheck = Int32.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }

        public int Calculate(int num1, int num2, string type)
        {
            //we declare our variables
            int result;

            //check operator type
            if (type == "+")
            {
                result = num1 + num2;
                return result;
            }
            else if (type == "-")
            {
                result = num1 - num2;
                return result;
            }
            else if (type == "*")
            {
                result = num1 * num2;
                return result;
            }
             else 
            {
                result = num1 / num2;
                return result;
            }
           
        }
    }
}
