using System;

namespace _07___KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numMatrix = int.Parse(Console.ReadLine());
            char[,] matrirxt = new char[numMatrix, numMatrix];
            ReadMatrix(matrirxt);

            int mostAttacks = int.MinValue;
            int knightBestRow = 0;
            int knightBestCol = 0;
            int countAttacks = 0;
            int countKnights = 0;

            while (mostAttacks!=0)
            {
                for (int i = 0; i < matrirxt.GetLength(0); i++)
                {
                    for (int j = 0; j < matrirxt.GetLength(1); j++)
                    {
                        char currentKnight = matrirxt[i, j];

                        if (currentKnight == 'K')
                        {
                            if (CheckTarggetKnight(matrirxt, i - 2, j - 1) && matrirxt[i - 2, j - 1] == 'K')
                            {
                                countAttacks++;
                            }
                            if (CheckTarggetKnight(matrirxt, i - 2, j + 1) && matrirxt[i - 2, j + 1] == 'K')
                            {
                                countAttacks++;
                            }
                            if (CheckTarggetKnight(matrirxt, i - 1, j - 2) && matrirxt[i - 1, j - 2] == 'K')
                            {
                                countAttacks++;
                            }
                            if (CheckTarggetKnight(matrirxt, i - 1, j + 2) && matrirxt[i - 1, j + 2] == 'K')
                            {
                                countAttacks++;
                            }
                            if (CheckTarggetKnight(matrirxt, i + 2, j - 1) && matrirxt[i + 2, j - 1] == 'K')
                            {
                                countAttacks++;
                            }
                            if (CheckTarggetKnight(matrirxt, i + 2, j + 1) && matrirxt[i + 2, j + 1] == 'K')
                            {
                                countAttacks++;
                            }
                            if (CheckTarggetKnight(matrirxt, i + 1, j - 2) && matrirxt[i + 1, j - 2] == 'K')
                            {
                                countAttacks++;
                            }
                            if (CheckTarggetKnight(matrirxt, i + 1, j + 2) && matrirxt[i + 1, j + 2] == 'K')
                            {
                                countAttacks++;
                            }
                        }
                        if (countAttacks > mostAttacks )
                        {
                            mostAttacks = countAttacks;
                            knightBestRow = i;
                            knightBestCol = j;
                        }
                        countAttacks = 0;
                    }                   
                }
                if (mostAttacks != 0)
                {
                    mostAttacks = -1;
                }
                matrirxt[knightBestRow, knightBestCol] = '0';
                countKnights++;
            }
            Console.WriteLine(countKnights-1);


            static void PrintMatrix(char[,] matrirxt)
            {
                for (int i = 0; i < matrirxt.GetLength(0); i++)
                {
                    for (int j = 0; j < matrirxt.GetLength(1); j++)
                    {
                        Console.Write(matrirxt[i, j]);
                    }
                    Console.WriteLine();
                }

            }

            static void ReadMatrix(char[,] matrirxt)
            {
                for (int i = 0; i < matrirxt.GetLength(0); i++)
                {
                    string charToInp = Console.ReadLine();
                    char[] charArr = charToInp.ToCharArray();

                    for (int j = 0; j < matrirxt.GetLength(1); j++)
                    {
                        matrirxt[i, j] = charArr[j];
                    }
                }
            }
        }

        private static bool CheckTarggetKnight(char[,] matrirxt, int targetRow, int targetCol)
        {
            bool isInMatrix = false;
            if (targetRow >= 0 && targetRow < matrirxt.GetLength(0))
            {
                if (targetCol >= 0 && targetCol < matrirxt.GetLength(1))
                {
                    isInMatrix = true;
                }
            }
            return isInMatrix;

        }
    }
}





