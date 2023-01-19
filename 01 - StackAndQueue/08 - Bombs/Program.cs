using System;
using System.Collections.Generic;
using System.Linq;

namespace _08___Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixRowAndCol = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixRowAndCol, matrixRowAndCol];

            InputMatrixNumbers(matrix);

            string[] delimeters = { " ", "," };

            int[] bombNumbers = Console.ReadLine()
                .Split(delimeters, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Dictionary<int, int> bombListCoordinate = new Dictionary<int, int>();

            ReadBombList(bombListCoordinate, bombNumbers);
            int alivecells = 0;
            int sum = 0;

            foreach (var bombPosition in bombListCoordinate)
            {
                int currentBombRow = bombPosition.Key;
                int currentBombColumn = bombPosition.Value;
                int bombPower = matrix[currentBombRow, currentBombColumn];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int row = i;
                        int column = j;
                        if (CheckNumberPosition(matrix, row, column) && matrix[row,column]>0)
                        {
                            matrix[row, column] -= bombPower;
                        }
                    }
                }

            }
            alivecells = ScanLiveCells(matrix);
            sum = SumMatrixCells(matrix);

            Console.WriteLine($"Alive cells: {alivecells}");
            Console.WriteLine($"Sum: {sum}");
            PrintMatrix(matrix);
        }
        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                    if (j<matrix.GetLength(1)-1)
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
        private static int SumMatrixCells(int[,] matrix)
        {
            int sumOfCells = 0;
            foreach (var item in matrix)
            {
                if (item>0)
                {
                    sumOfCells += item;
                }
            }
            return sumOfCells;
        }
        private static int ScanLiveCells(int[,] matrix)
        {
            int alivecell = 0;
            foreach (var item in matrix)
            {
                if (item>0)
                {
                    alivecell++;
                }
            }
            return alivecell;
        }

        private static bool CheckNumberPosition(int[,] matrix, int row, int column)
        {
            bool isValid = false;
            if (row >= 0 && row < matrix.GetLength(0))
            {
                if (column >= 0 && column < matrix.GetLength(1))
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        private static void ReadBombList(Dictionary<int, int> bombListCoordinate, int[] bombNumbers)
        {
            for (int i = 0; i < bombNumbers.Length; i+=2)
            {
                bombListCoordinate.Add(bombNumbers[i], bombNumbers[i + 1]);
            }
        }

        private static void InputMatrixNumbers(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }
        }
    }
}
