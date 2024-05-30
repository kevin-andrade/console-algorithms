using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMiniCalculator
{
    internal class Input
    {
        public string GetOperation()
        {
            string choice;
            bool isValid = false;

            do
            {
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                choice = Console.ReadLine();

                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter a operation valid.");
                    Console.WriteLine();
                }
                

            } while (!isValid);

            return choice;
        }

        public double GetNumber(string promptMessage)
        {
            bool isValid;
            double number;

            do
            {
                Console.WriteLine(promptMessage);
                string input = Console.ReadLine();
                isValid = double.TryParse(input, out number);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number");
                }
               
            } while (!isValid);

            return number;
        }

    }
}
