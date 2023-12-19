using System.Globalization;

namespace VerifiedChange
{
    class Program
    {
        private const string ProductPriceMessage = "Produt unit price: ";
        private const string ProductQuantityMessage = "Quantity purchased: ";
        private const string PaymentAmountMessage = "Enter the payment amount: ";
        private const string InvalidInputMessage = "Invalid input. Please enter a valid positive number.";

        static void Main(string[] args)
        {
            Console.WriteLine("Shopping cart");
            double price = GetValidInput<double>(ProductPriceMessage, x => x > 0);
            int qty = GetValidInput<int>(ProductQuantityMessage, x => x > 0);
            double paymentAmount = GetValidInput<double>(PaymentAmountMessage, x => x > 0);
            double change = CalculateChange(price, qty, paymentAmount);
            DisplayChange(change);
        }

        static double CalculateChange(double price, int qty, double paymentAmount)
        {
            double total = price * qty;
            double change = paymentAmount - total;
            return change;
        }

        static T GetValidInput<T>(string message, Func<T, bool> validation)
        {
            Console.Write(message);

            T input;
            while (!TryGetInput(out input) || !validation(input))
            {
                Console.WriteLine(InvalidInputMessage);
                Console.Write(message);
            }

            return input;
        }

        static bool TryGetInput<T>(out T result)
        {
            string userInput = Console.ReadLine();

            try
            {
                result = (T)Convert.ChangeType(userInput, typeof(T), CultureInfo.InvariantCulture);
                return true;
            }
            catch (InvalidCastException)
            {
                result = default;
                return false;
            }
        }

        static void DisplayChange(double change)
        {
            if (change < 0)
            {
                Console.WriteLine($"INSUFFICIENT MONEY. MISSING {Math.Abs(change):F2}");
            }
            else
            {
                Console.WriteLine($"CHANGE = {change:F2} R$");
            }
        }
    }
}