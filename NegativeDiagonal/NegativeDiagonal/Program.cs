namespace NegativeDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayOrder = ArrayOrder();
            int[,] matrix = CreateMatrix(arrayOrder);
            FillMatrix(matrix);
            int numberNegatives = CountNumberNegatives(matrix);
            DisplayMatrix(matrix);
            DisplayMainDiagonal(matrix);
            DisplayCountNumberNegatives(numberNegatives);
        }

        static int ArrayOrder()
        {
            int arrayOrder;
            do
            {
                Console.Write("Enter the array order: ");
                if(!int.TryParse(Console.ReadLine(), out arrayOrder) || ArrayOrderIsInValid(arrayOrder))
                {
                    Console.WriteLine("Invalid array order. Please, enter a valid integer.");
                }
            } while (ArrayOrderIsInValid(arrayOrder));

            return arrayOrder;
        }

        static bool ArrayOrderIsInValid(int arrayOrder)
        {
            return arrayOrder <= 0;
        }

        static int[,] CreateMatrix(int arrayOrder)
        {
            return new int[arrayOrder, arrayOrder];
        }

        static void DisplayMatrix(int[,] mat)
        {
            Console.WriteLine("MATRIX");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine();
        }

        static void DisplayMainDiagonal(int[,] mat)
        {
            Console.WriteLine("MAIN DIAGONAL: ");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write(mat[i, i] + "\t");
            }
            Console.WriteLine();
        }

        static void DisplayCountNumberNegatives(int count)
        {
            Console.WriteLine();
            Console.WriteLine("NUMBER NEGATIVE: ");
            Console.Write(count);
        }

        static int CountNumberNegatives(int[,] mat)
        {
            int count = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static void FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Enter the value for element at position [{i}, {j}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                    {
                        Console.WriteLine("Invalid input. Please, enter a valid integer.");
                        Console.Write($"Enter the value for element at position [{i}, {j}]: ");
                    }
                }
            }
            Console.WriteLine();
        }
    }

}