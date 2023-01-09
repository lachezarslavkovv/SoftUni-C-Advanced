using System;
using System.Linq;

namespace _03___MatrixSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = numbers[0];
            int columns = numbers[1];
            int[,] matrix = new int[rows, columns];
            long maxSum = long.MinValue;

            int startRow = 0;
            int startCol = 0;
            InputMatruxNumbers(matrix);



            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int currentRow = i;
                    int currentColumn = j;
                    long currentSum = CheckMatrixSum(matrix,currentRow,currentColumn);
                    if (currentSum > maxSum)
                    {
                        startRow = currentRow;
                        startCol = currentColumn;
                        maxSum = currentSum;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine("Sum = "+ maxSum);
            PrintMatrix(matrix, startRow, startCol);

        }

        private static void PrintMatrix(int[,] matrix, int startRow, int startCol)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[startRow+i,startCol+j]);
                    if (j!=2)
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }

        private static long CheckMatrixSum(int[,] matrix, int currentRow, int currentColumn)
        {
            long currentSum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    currentSum += matrix[currentRow + i, currentColumn + j];
                }
            }
            return currentSum;
        }

        private static void InputMatruxNumbers(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }
        }
    }
}
