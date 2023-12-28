namespace OddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = GetNumbers();
            int sum = CalculateOddNumbers(numbers);
            DisplayResult(sum);
        }

        static List<int> GetNumbers()
        {
            List<int> numbers = new List<int>();
            int number;

            for (int i = 1; i <= 2; i++)
            {
                Console.Write("Enter your number: ");
                if(!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid number. Please, try again.");
                    i--;
                }
                numbers.Add(number);
            }

            return numbers;
        }

        static int CalculateOddNumbers(List<int> numbers)
        {
            int x = numbers.First();
            int y = numbers.Last();

            (x, y) = Swap(x, y);

            int sum = 0;
            for (int i = x + 1; i < y - 1; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        static (int, int) Swap(int x, int y)
        {
            if (x > y)
            {
                return (y, x);
            }
            return (x, y);
        }

        static void DisplayResult(int result)
        {
            Console.WriteLine($"Sum of odd numbers : {result}");
        }
    }
}