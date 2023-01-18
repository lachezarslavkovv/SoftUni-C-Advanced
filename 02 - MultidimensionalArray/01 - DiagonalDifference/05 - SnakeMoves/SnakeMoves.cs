using System;
using System.Linq;

namespace _05___SnakeMoves
{
    class SnakeMoves
    {
        static void Main(string[] args)
        {
            int[] matrixRowCol = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int rows = matrixRowCol[0];
            int collumns = matrixRowCol[1];
            char[,] matrix = new char[rows, collumns];
            char[] snake = Console.ReadLine().ToCharArray();
            int currentSymbol = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (currentSymbol == snake.Length)
                        {
                            currentSymbol = 0;
                        }
                        matrix[i, j] = snake[currentSymbol];
                        currentSymbol++;
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        if (currentSymbol == snake.Length)
                        {
                            currentSymbol = 0;
                        }
                        matrix[i, j] = snake[currentSymbol];
                        currentSymbol++;

                    }
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);

                }
                Console.WriteLine();
            };
        }
    }
}
