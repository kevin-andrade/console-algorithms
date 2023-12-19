namespace LessThanThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Find smallest number in the list**\n");

            List<int> numbers = ReadNumbersUser();
            if (numbers.Count > 0)
            {
                int numberSmaller = FindSmallestNumber(numbers);
                Console.WriteLine($"SMALLEST NUMBER = {numberSmaller}");
            }
            else
            {
                Console.WriteLine("No number was entered or the entry was invalid.");
            }
        }

        static List<int> ReadNumbersUser()
        {
            List<int> numbers = new List<int>();

            Console.Write("Quantity: ");
            if (int.TryParse(Console.ReadLine(), out int qty) && qty > 0)
            {
                int i = 1;
                while (i <= qty)
                {
                    Console.Write($"value #{i}: ");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        numbers.Add(number);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try again.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid quantity. Please enter a positive number.");
            }
            return numbers;
        }

        static int FindSmallestNumber(List<int> list)
        {
            if (list == null || list.Count < 0)
            {
                throw new ArgumentException("The list is empty or null.");
            }

            int smaller = list[0];
            foreach (int n in list)
            {
                if (n < smaller)
                {
                    smaller = n;
                }
            }

            return smaller;
        }
    }
}
