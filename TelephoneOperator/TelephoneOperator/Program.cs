namespace TelephoneOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Telephone operator**");
            int minutes = GetMinutesFromUser();
            double totalCost = CalculateFranchiseComsuption(minutes);
            Console.WriteLine($"Amount payable: $ {totalCost:F2}");
        }

        static double CalculateFranchiseComsuption(int minutes)
        {
            const int franchiseMinutes = 100;
            const double basicPlanCost = 50.0;
            const double excessMinutesCost = 2.0;

            double totalCost = basicPlanCost;

            if (minutes > franchiseMinutes)
            {
                totalCost = basicPlanCost + (minutes - franchiseMinutes) * excessMinutesCost;
            }
            return totalCost;
        }

        static int GetMinutesFromUser()
        {
            Console.Write("Enter the number of minutes: ");

            if (int.TryParse(Console.ReadLine(), out int minutes))
            {
                return minutes;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of minutes.");
                return GetMinutesFromUser();
            }
        }
    }
}