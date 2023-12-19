using System.Globalization;

namespace DartDistance
{
    class Program
    {
        private const string DistanceMessage = "Enter the three distances:";
        private const string InputInvalidMessage = "Invalid input. Try again";
        private const int TotalQuantity = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("Calculation of dart distance");
            List<double> inputDistance = GetValidInputDistance();
            double greater = FindGreaterDistance(inputDistance);
            DisplayGreaterDistance(greater);
        }

        static List<double> GetValidInputDistance()
        {
            List<double> list = new List<double>();

            Console.WriteLine(DistanceMessage);
            int i = 1;
            while (i <= TotalQuantity)
            {
                Console.Write($"Distance #{i}: ");
                string input = Console.ReadLine().Replace(',', '.');
                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double number) && number > 0)
                {
                    list.Add(number);
                    i++;
                }
                else
                {
                    Console.WriteLine(InputInvalidMessage);
                }
            }

            return list;
        }

        static double FindGreaterDistance(List<double> list)
        {
            if (list == null || list.Count < 0)
            {
                throw new ArgumentNullException(nameof(list), "The list is empty or null.");
            }

            double greater = list[0];
            foreach (double x in list)
            {
                if (x > greater)
                {
                    greater = x;
                }
            }

            return greater;
        }

        static void DisplayGreaterDistance(double greater)
        {
            Console.WriteLine($"GREATER DISTANCE = {greater.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}