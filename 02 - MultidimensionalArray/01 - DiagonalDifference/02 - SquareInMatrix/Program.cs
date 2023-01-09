using System;
using System.Linq;

namespace _02___SquareInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = numbers[0];
            int columns = numbers[1];
            char[,] matrix = new char[rows, columns];
            int counterCouples = 0;
            InputMatrixNumbers(matrix);

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    char symbolToCheck = matrix[i, j];
                    int currentRow = i;
                    int currentColumn = j;
                    bool IsCorrect = CheckSymbols(matrix, symbolToCheck, currentRow, currentColumn);
                    if (IsCorrect)
                    {
                        counterCouples++;
                    }
                }
            }
            Console.WriteLine(counterCouples);
            
        }

        private static bool CheckSymbols(char[,] matrix, char symbolToCheck, int currentRow, int currentColumn)
        {
            bool isCorrect = true;

            for (int i = currentRow; i < currentRow+2; i++)
            {
                for (int j = currentColumn; j < currentColumn+2; j++)
                {
                    char currentSymbol = matrix[i, j];
                    if (symbolToCheck != currentSymbol)
                    {
                        isCorrect = false;
                        return false;
                    }
                }
            }
            return isCorrect;

        }

        private static void InputMatrixNumbers(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] symbols = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = symbols[j];
                }
            }
        }
    }
}
