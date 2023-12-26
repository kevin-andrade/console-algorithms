using System.Globalization;

namespace Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = GetCoordinate("X");
            double y = GetCoordinate("Y");
            DeterminePosition(x, y);
        }

        static double GetCoordinate(string nameCoordinate)
        {
            double coordinate;
            while (true)
            {
                Console.Write($"Enter the coordinate {nameCoordinate}: ");
                string input = Console.ReadLine().Replace(',', '.');
                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out coordinate))
                {
                    break;
                }
                Console.WriteLine("Invalid coordinate. Try again.");
            }
            return coordinate;
        }

        static void DeterminePosition(double x, double y)
        {
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origin");
            }
            else if (x == 0)
            {
                Console.WriteLine("Axis Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Axis X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}