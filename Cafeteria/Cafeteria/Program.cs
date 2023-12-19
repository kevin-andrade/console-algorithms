namespace Cafeteria
{
    class Program
    {
    const int productOneCode = 1;
    const double productOneValue = 5.00;

    const int productTwoCode = 2;
    const double productTwoValue = 3.50;

    const int productThreeCode = 3;
    const double productThreeValue = 4.80;

    const int productFourCode = 4;
    const double productFourValue = 8.90;

    const int productFiveCode = 5;
    const double productFiveValue = 7.32;

        static void Main(string[] args)
        {
            int code = GetProductCode();
            double productValue = GetProductValue(code);
            int quantityPurchased = GetQuantityPurchased();
            double amountToPay = Payment(productValue, quantityPurchased);
            DisplayAmountToPay(amountToPay);
        }

        static int GetProductCode()
        {
            int code;
            while (true)
            {
                Console.Write("Purchased product code (1 to 5): ");
                if (int.TryParse(Console.ReadLine(), out code) && code >=1 & code <= 5)
                {
                    break;
                }

                Console.WriteLine("Invalid code. Try again.");
            }
            return code;
        }

        static double GetProductValue(int productCode)
        {
            switch(productCode)
            {
                case productOneCode:
                    return productOneValue;
                case productTwoCode:
                    return productTwoValue;
                case productThreeCode:
                    return productThreeValue;
                case productFourCode:
                    return productFourValue;
                case productFiveCode:
                    return productFiveValue;
                default:
                    return -1;
            }
        }

        static int GetQuantityPurchased()
        {
            int quantity;
            while (true)
            {
                Console.Write("Quantity purchased: ");
                if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Try again.");
            }
            return quantity;
        }

        static double Payment(double value, int quantity)
        {
            return value * quantity;
        }

        static void DisplayAmountToPay(double amountToPay)
        {
            Console.WriteLine($"AMOUNT TO PAY: R$ {amountToPay:F2}");
        }
    }
}