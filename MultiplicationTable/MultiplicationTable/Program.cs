namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumber();
            DisplayMultiplicationTable(number);
        }

        static int GetNumber()
        {
            int number;

            while (true)
            {
                Console.Write("What value do you want the multiplication table for: ");
                if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid number. Please, try again.");
            }

            return number;
        }

        static int CalculateMultiplicationTables(int multiplying, int multiplier)
        {
            return multiplying * multiplier;
        }

        static void DisplayMultiplicationTable(int number)
        {
            Console.WriteLine();
            Console.WriteLine($"NUMBER TABLES {number}");

            for (int i = 1; i <= 10; i++)
            {
                int result = CalculateMultiplicationTables(number, i);
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
}