namespace CalculationsLines
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = GetLine();
            int column = GetColumn();
            int[,] matrix = CreateMatrix(line, column);
            FillMatrix(matrix);
            SumRows(matrix);
        }

        static int GetLine()
        {
            int line;
            do
            {
                Console.Write("How many rows are in the matrix? ");
                if (!int.TryParse(Console.ReadLine(), out line) || IntegerNumberIsInvalid(line))
                {
                    Console.WriteLine("Invalid row. Please, enter a valid integer.");
                }
            } while (IntegerNumberIsInvalid(line));

            return line;
        }

        static int GetColumn()
        {
            int column;
            do
            {
                Console.Write("How many columns are in the matrix? ");
                if (!int.TryParse(Console.ReadLine(), out column) || IntegerNumberIsInvalid(column))
                {
                    Console.WriteLine("Invalid column. Please, enter a valid integer.");
                }
            } while (IntegerNumberIsInvalid(column));

            return column;
        }

        static bool IntegerNumberIsInvalid(int number)
        {
            return number <= 0 || number >= 10;
        }

        static int[,] CreateMatrix(int line, int column)
        {
            return new int[line, column];
        }

        static void FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine($"Enter the elements of {i + 1}st. Line?");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Enter the value for element at position [{i}, {j}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                    {
                        Console.WriteLine("Invalid input. Please, enter a valid integer.");
                        Console.Write($"Enter the value for element at position [{i}, {j}]: ");
                    }
                }
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=");
            }
            Console.WriteLine();
        }

        static void SumRows(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i,j];
                }
                Console.WriteLine($"Sum of elements in row {i + 1}: {sum}");
            }
        }

    }
}
