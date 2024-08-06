using System;

namespace EditorHTML
{
    public static class Menu
    {

        const int size = 20;
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;

            DrawScreen();
            WriteOptions();
            short option = GetUserOption();
            HandleUserOption(option);
        }

        public static void DrawScreen()
        {
            Console.Clear();
            Console.WriteLine("Simple HTML editor");
            DrawHorizontalBorder();
            for (int i = 0; i < size - 2; i++)
            {
                DrawVerticalBorder();
            }
            DrawHorizontalBorder();
        }

        public static void DrawHorizontalBorder()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("=-=");
            }
            Console.WriteLine();
        }
        public static void DrawVerticalBorder()
        {
            Console.Write("|");

            for (int i = 0;i < (size * 3) - 2; i++)
            {
                Console.Write(' ');
            }
            Console.WriteLine("|");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("EDITOR HTML");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Select an option below");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("1 - New File");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("2 - Open File");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("0 - Exit");
        }

        public static short GetUserOption()
        {
            short option;
            bool validOption;
            do
            {
                Console.SetCursorPosition(3, 12);
                Console.Write("Option: ");
                validOption = short.TryParse(Console.ReadLine(), out option);

                if (!validOption || option < 0 || option > 2)
                {
                    Console.SetCursorPosition(3, 12);
                    Console.WriteLine("Invalid option. Please try again.");
                    validOption = false;
                }
            } while (!validOption);

            return option;
        }

        public static void HandleUserOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show();break;
                case 2: Viewer.Show("");break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);break;
                    }
                default: Show();break;
            }
        }
    }
}