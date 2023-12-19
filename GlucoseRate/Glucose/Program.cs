using System.Globalization;

namespace Glucose
{
    class Program
    {
        private const string GlucoseValueMessage = "Enter the glucose measurement: ";
        private const string InputInvalidMessage = "Invalid Input. Make sure you enter a valid number.";

        static void Main(string[] args)
        {
            Console.WriteLine("GLUCOSE CHECK");
            double glucoseValue = GetValidInputGlucose();
            string glucoseRate = ClassifyGlucose(glucoseValue);
            DisplayGlucoseRate(glucoseRate);
        }

        static string ClassifyGlucose(double glucoseValue)
        {
            if (glucoseValue < 70)
            {
                return "Hypoglycemia";
            }
            else if (glucoseValue >= 70 && glucoseValue <= 100)
            {
                return "Normal";
            }
            else if (glucoseValue > 100 && glucoseValue <= 125)
            {
                return "High Fasting Glucose (Prediabetes)";
            }
            else if (glucoseValue > 125 && glucoseValue <= 160)
            {
                return "High postprandial glucose";
            }
            else if (glucoseValue > 160 && glucoseValue <= 200)
            {
                return "Glucose intoleranceValue (Pre-diabetes)";
            }
            else
            {
                return "Diabetes";
            }
        }

        static double GetValidInputGlucose()
        {
            double glucoseValue;
            bool validEntry = false;

            do
            {
                Console.Write(GlucoseValueMessage);
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out glucoseValue))
                {
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine(InputInvalidMessage);
                }
            } while (!validEntry);

            return glucoseValue;
        }

        static void DisplayGlucoseRate(string glucoseRate)
        {
            Console.WriteLine($"Classification: {glucoseRate}");
        }
    }
}