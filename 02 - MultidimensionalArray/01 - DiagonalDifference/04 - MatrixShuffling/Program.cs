using System;
using System.Linq;

namespace _04___MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersMatrix = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = numbersMatrix[0];
            int columns = numbersMatrix[1];
            string[,] matrix = new string[rows, columns];
            
            InputMatrixNumbers(matrix);

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandElements = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);


                bool correctInput = false;

                if (commandElements[0] == "swap" && commandElements.Length == 5)
                {
                    correctInput = CheckElement(matrix, commandElements);
                }
                if (correctInput)
                {
                    int firstNumRow = int.Parse(commandElements[1]);
                    int firstNumCol = int.Parse(commandElements[2]);
                    int secondNumRow = int.Parse(commandElements[3]);
                    int secondNumCol = int.Parse(commandElements[4]);


                    string tempNumber = matrix[int.Parse(commandElements[1]), int.Parse(commandElements[2])];

                    matrix[firstNumRow, firstNumCol] = matrix[secondNumRow, secondNumCol];
                    matrix[secondNumRow, secondNumCol] = tempNumber;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }

        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                    if (j != matrix.GetLength(1)-1)
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            };
        }

        private static bool CheckElement(string[,] matrix, string[] commandElements)
        {
            int firstNumRow = int.Parse(commandElements[1]);
            int firstNumCol = int.Parse(commandElements[2]);
            int secondNumRow = int.Parse(commandElements[3]);
            int secondNumCol = int.Parse(commandElements[4]);

            bool correct = false;

            if (firstNumRow >= 0 && secondNumRow >= 0 && firstNumRow < matrix.GetLength(0) && secondNumRow < matrix.GetLength(0))
            {
                if (firstNumCol >= 0 && secondNumCol >= 0 && firstNumCol < matrix.GetLength(1) && secondNumCol < matrix.GetLength(1))
                {
                    correct = true;
                }
            }

            return correct;

        }

        private static void InputMatrixNumbers(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }
        }
    }
}
