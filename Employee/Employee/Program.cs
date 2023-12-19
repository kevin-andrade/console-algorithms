using System.Globalization;

namespace Employee
{
    class Program
    {
        static void Main(string[] args) 
        {
            Employee e = new Employee();

            Console.WriteLine("Enter employee details:");

            Console.Write("Name: ");
            e.Name = Console.ReadLine();
            Console.Write("Gross salary: ");
            e.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tax:");
            e.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Employee: " + e);

            Console.WriteLine("Enter the percentage to increase the salary: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            e.IncreaseSalary(percent);

            Console.WriteLine();
            Console.WriteLine("Updated data: " + e);
        }
    }
}