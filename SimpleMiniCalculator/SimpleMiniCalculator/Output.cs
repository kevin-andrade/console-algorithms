using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMiniCalculator
{
    public class Output
    {
        public void ShowResult(double result) {
            Console.WriteLine($"\nThe result is: {result}"); 
        }

        public void ShowError(string message)
        {
            Console.WriteLine($"\nError: {message}");
        }

        public void ShowMessage(string message) { Console.Write(message); }
    }
}
