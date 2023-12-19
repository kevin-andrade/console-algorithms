using System.Globalization;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenuChoices();
            int choice = GetUserChoice();
            double temperature = GetTemperatureUser();
            double result = PerformConversion(temperature, choice);
            DisplayResult(temperature, result, choice);
        }

        static int GetUserChoice()
        {
            int choice;

            do
            {
                Console.Write("Enter your choice (1 or 2): ");
                if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
                {
                    Console.WriteLine("Invalid choice. Please enter either 1 or 2 and try again.");
                }
            } while (choice != 1 && choice != 2);

            return choice;
        }

        static double GetTemperatureUser()
        {
            double temperature;

            do
            {
                Console.Write("Enter your temperature: ");
                string input = Console.ReadLine();
                if (!double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out temperature) || !IsTemperatureValid(temperature))
                {
                    Console.WriteLine("Invalid input. Please enter a valid temperature within the range of -89.2 to 56.7.");
                }
            } while (!IsTemperatureValid(temperature));

            return temperature;
        }

        static bool IsTemperatureValid(double temperature)
        {
            return temperature >= -89.2 && temperature <= 56.7;
        }

        static double PerformConversion(double temperature, int choice)
        {
            if (choice == 1)
            {
                return ConvertCelsiusToFahrenheit(temperature);
            }
            return ConvertFahrenheitToCelsius(temperature);
        }

        static double ConvertCelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5.0) * celsius + 32;
            return fahrenheit;
        }

        static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9.0) * (fahrenheit - 32);
            return celsius;
        }

        static void DisplayMenuChoices()
        {
            Console.WriteLine("Choose temperature conversion:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
        }

        static void DisplayResult(double temperature, double result, int choice)
        {
            string inputUnit = choice == 1 ? "Fahrenheit":"Celsius";
            string outputUnit = choice == 1 ? "Celsius":"Fahrenheit";

            Console.WriteLine($"{temperature} {inputUnit} is equal to {result} {outputUnit}.");
        }
    }
}