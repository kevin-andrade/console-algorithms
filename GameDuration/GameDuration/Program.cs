using System.Globalization;

namespace GameDuration
{
    class Program
    {
        private const string startTimeMessage = "Enter the start time (HH:mm): ";
        private const string endTimeMessage = "Enter the end time (HH:mm): ";

        static void Main(string[] args)
        {
            DateTime startTime = GetTime(startTimeMessage);
            DateTime endTime = GetTime(endTimeMessage);
            TimeSpan matchDuration = CalculateMatchDuration(startTime, endTime);
            DisplayResult(matchDuration);
        }

        static DateTime GetTime(string message)
        {
            DateTime time;

            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (DateTime.TryParseExact(input, "HH:mm", null, DateTimeStyles.None, out time))
                {
                    if (time.Hour == 0 && time.Minute == 0)
                    {
                        time = new DateTime(1, 1, 2, time.Hour, time.Minute, 0);
                    }
                    else
                    {
                        time = new DateTime(1, 1 , 1, time.Hour, time.Minute, 0);
                    }
                    break;
                }
                Console.WriteLine("Invalid time format. Please try again (HH:mm).");
            }

            return time;
        }

        static TimeSpan CalculateMatchDuration(DateTime startTime, DateTime endTime)
        {
            if (startTime == endTime)
            {
                return TimeSpan.FromHours(24);
            }

            if (startTime < endTime)
            {
                return endTime - startTime;
            }
            return (TimeSpan.FromHours(24) - startTime.TimeOfDay) + endTime.TimeOfDay;
        }

        static void DisplayResult(TimeSpan matchDuration)
        {
            Console.WriteLine($"The duration of the match was: {matchDuration.Hours} hours and {matchDuration.Minutes} minutes.");
        }
    }
}