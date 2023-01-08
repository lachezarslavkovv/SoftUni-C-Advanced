using System;
using System.Linq;

namespace _01___DiagonalDifference
{
    internal class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeMatrix, sizeMatrix];

            IntputMatrixElements(matrix, sizeMatrix);
            int sumPrimaryDiagonal = SumPrimaryDiagonal(matrix);
            int sumSecondaryDiagonal = SumSecondaryDiagonal(matrix);
            Console.WriteLine(Math.Abs(sumPrimaryDiagonal-sumSecondaryDiagonal));
        }

        private static int SumSecondaryDiagonal(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, matrix.GetLength(0)-1-i];
            }
            return sum;
        }

        private static int SumPrimaryDiagonal(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }

        static void IntputMatrixElements(int[,] matrix, int sizeMatrix)
        {
            for (int i = 0; i < sizeMatrix; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < sizeMatrix; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }
        }
    }
}
