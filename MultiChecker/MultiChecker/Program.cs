namespace MultiChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = GetbaseNumber();
            int numberCheck = GetNumberCheck();
            DisplayResultMultiple(baseNumber, numberCheck);
        }

        static int GetbaseNumber()
        {
            int baseNumber;
            while (true)
            {
                Console.Write("Enter the base number: ");
                if (int.TryParse(Console.ReadLine(), out baseNumber) && baseNumber > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid number. Try again");
            }
            return baseNumber;
        }

        static int GetNumberCheck()
        {
            int numberCheck;
            while (true)
            {
                Console.Write("Enter the number check: ");
                if (int.TryParse(Console.ReadLine(), out numberCheck) && numberCheck > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid number. Try again");
            }
            return numberCheck;
        }

        static bool CheckMultiple(int baseNumber, int numberCheck)
        {
            return baseNumber % numberCheck == 0;
        }

        static bool TheyAreMultiple(int baseNumber, int numberCheck)
        {
            return CheckMultiple(baseNumber, numberCheck) || CheckMultiple(numberCheck, baseNumber);
        }

        static void DisplayResultMultiple(int baseNumber, int numberCheck)
        {
            if (TheyAreMultiple(baseNumber, numberCheck))
            {
                Console.WriteLine($"{baseNumber} and {numberCheck} are multiples of each other");
            }
            else
            {
                Console.WriteLine($"{baseNumber} and {numberCheck} are not multiples of each other");
            }
        }
    }
}