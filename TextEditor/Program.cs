using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Hello, what do you want to do?");
            Console.WriteLine();
            Console.WriteLine("1 -> Open file");
            Console.WriteLine("2 -> Create new file");
            Console.WriteLine("0 -> Exit");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: OpenFile(); break;
                case 2: EditFile(); break;
                default: Menu(); break;
            }
        }

        static void OpenFile()
        {
            Console.Clear();
            Console.WriteLine("Which path do you want to open?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void SaveFile(string text)
        {
            Console.Clear();
            Console.WriteLine("Which path do you want to save the file?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"File Saved Successfully");
            Console.ReadLine();
            Menu();
        }

        static void EditFile()
        {
            Console.Clear();
            Console.WriteLine("Enter your text below (Press ESC to exit");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            SaveFile(text);
        }
    }
}