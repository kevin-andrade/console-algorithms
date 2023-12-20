using System.Globalization;

namespace SalaryIncrease
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = GetUserSalary();
            double percentual = PercentageSalaryTable(salary);
            double salaryIncrease = CalculateSalaryIncrease(salary, percentual);
            double newSalary = CalculateNewSalary(salary, salaryIncrease);
            DisplaySalaryIncrease(newSalary, salaryIncrease, percentual);
        }

        static double GetUserSalary()
        {
            double salary;
            while (true)
            {
                Console.Write("Enter the salary amount: ");
                string input = Console.ReadLine().Replace(',', '.');
                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out salary) && salary > 0 )
                {
                    break;
                }
                Console.WriteLine("Invalid salary. Try again.");
            }
            return salary;
        }

        static double PercentageSalaryTable(double salary)
        {
            if (salary <= 1000.00)
            {
                return 20.0;
            }
            else if (salary > 1000.00 && salary <= 3000.00)
            {
                return 15.0;
            }
            else if (salary > 3000.00 && salary <= 8000.00)
            {
                return 10.0;
            }
            else
            {
                return 5.0;
            }
        }

        static double CalculateNewSalary(double salary, double salaryIncrease)
        {
            return salary + salaryIncrease;
        }

        static double CalculateSalaryIncrease(double salary, double percentual)
        {
            return (salary * percentual) / 100.00;
        }

        static void DisplaySalaryIncrease(double newSalary, double salaryIncrease, double percentual)
        {
            Console.WriteLine($"New salary = {newSalary:F2}");
            Console.WriteLine($"Salary increase = {salaryIncrease:F2}");
            Console.WriteLine($"Percentagem = {Math.Round(percentual)} %");
        }
    }
}