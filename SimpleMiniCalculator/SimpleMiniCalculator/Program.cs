namespace SimpleMiniCalculator;

public class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        Input inputNumber = new Input();
        Output output = new Output();
        bool running = true;

        while (running)
        {
            Console.Clear();

            string choice = inputNumber.GetOperation();

            if (choice == "5")
            {
                running = false;
                continue;
            }

            double number1 = inputNumber.GetNumber("Number 1: ");
            double number2 = inputNumber.GetNumber("Number 2: ");
            try
            {
                double result = 0;

                switch (choice)
                {
                    case "1":
                        result = calculator.Add(number1, number2);
                        break;
                    case "2":
                        result = calculator.Subtract(number1, number2);
                        break;
                    case "3":
                        result = calculator.Multiply(number1, number2);
                        break;
                    case "4":
                        result = calculator.Divide(number1, number2);
                        break;
                    default:
                        output.ShowMessage("Invalid choice. Please select a valid operation.");
                        continue;
                }

                output.ShowResult(result);
            }
            catch (Exception ex)
            {
                output.ShowError(ex.Message);
            }

            output.ShowMessage("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}