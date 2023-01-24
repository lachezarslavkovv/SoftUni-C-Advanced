using System;

namespace _07___KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowAndCol = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rowAndCol, rowAndCol];

            int maxAttacks = int.MinValue;
            int currentKnightRow = 0;
            int currentKnightCol = 0;
            int currentKnightAttacks = 0;
            int totalKnightRemoved = 0;

            InputMatrixElements(matrix);


            while (maxAttacks != 0)
            {
                maxAttacks = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        char currentPosition = matrix[i, j];
                        if (currentPosition == 'K')
                        {
                            if (CheckKnightPosition(matrix, i - 2, j - 1) && matrix[i - 2, j - 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (CheckKnightPosition(matrix, i - 2, j + 1) && matrix[i - 2, j + 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (CheckKnightPosition(matrix, i - 1, j - 2) && matrix[i - 1, j - 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (CheckKnightPosition(matrix, i - 1, j + 2) && matrix[i - 1, j + 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (CheckKnightPosition(matrix, i + 1, j - 2) && matrix[i + 1, j - 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (CheckKnightPosition(matrix, i + 1, j + 2) && matrix[i + 1, j + 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (CheckKnightPosition(matrix, i + 2, j - 1) && matrix[i + 2, j - 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (CheckKnightPosition(matrix, i + 2, j + 1) && matrix[i + 2, j + 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }

                            if (currentKnightAttacks > maxAttacks)
                            {
                                maxAttacks = currentKnightAttacks;
                                currentKnightRow = i;
                                currentKnightCol = j;
                            }
                            currentKnightAttacks = 0;
                        }
                    }


                }
                if (maxAttacks > 0)
                {
                    matrix[currentKnightRow, currentKnightCol] = '0';
                    totalKnightRemoved++;
                }

            }
            Console.WriteLine(totalKnightRemoved);
        }

        private static bool CheckKnightPosition(char[,] matrix, int targetRow, int targetCol)
        {
            bool isInMatrix = false;
            if (targetRow >= 0 && targetRow < matrix.GetLength(0))
            {
                if (targetCol >= 0 && targetCol < matrix.GetLength(1))
                {
                    isInMatrix = true;
                }
            }
            return isInMatrix;
        }

        private static void InputMatrixElements(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string text = Console.ReadLine();
                char[] items = text.ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = items[j];
                }
            }
        }
    }
}
