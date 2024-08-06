using System;

namespace EditorHTML
{
    public static class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("MODE VIEW");
            Console.WriteLine("===========================");
            // text
            Console.WriteLine("===========================");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
            Menu.Show();
        }
    }
}
