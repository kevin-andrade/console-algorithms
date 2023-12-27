namespace AverageAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = GetUserAge();
            double averageAge = CalculateAverageAges(ages);
            DisplayAverageAge(averageAge);
        }

        static List<int> GetUserAge()
        {
            List<int> ages = new List<int>();
            int age;

            while (true)
            {
                Console.Write("Enter your age (enter a negative value to end): ");
                if (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Invalid age. Try again");
                    continue;
                }

                if (age < 0 || age >= 140)
                {
                    Console.WriteLine("Shutting down");
                    break;
                }

                ages.Add(age);
            }

            return ages;
        }

        static double CalculateAverageAges(List<int> ages)
        {
            int sum = 0;
            int count = 0;

            foreach (int age in ages)
            {
                if (age > 0)
                {
                    sum = sum + age;
                    count++;
                }
            }

            double averageAge = count > 0 ? (double)sum / count : 0;
            return averageAge;
        }

        static void DisplayAverageAge(double averageAge)
        {
            Console.WriteLine($"Average age = {averageAge:F2}");
        }

    }
}