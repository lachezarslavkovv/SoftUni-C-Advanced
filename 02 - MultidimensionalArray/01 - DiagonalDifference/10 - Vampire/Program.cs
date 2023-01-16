using System;
using System.Linq;

namespace _10___Vampire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = numbers[0];
            int col = numbers[1];
            char[,] matritrx = new char[rows, col];
            Fillmatrix(matritrx);
            char[] commands = Console.ReadLine().ToCharArray();
            int playerRowPosition;
            int playerColPosition;

            int[] positionPlayer = FindPlayerPosition(matritrx);
            playerRowPosition = positionPlayer[0];
            playerColPosition = positionPlayer[1];

            for (int i = 0; i < commands.Length; i++)
            {
                CheckPossiblePosition(matritrx, playerRowPosition, playerColPosition, commands[i]);
            }


        }

        private static void CheckPossiblePosition(char[,] matritrx, int playerRowPosition, int playerColPosition, char command)
        {
            if (command =='U')
            {
                playerColPosition--;
                if (matritrx[play])
                {

                }
            }
        }

        private static int[] FindPlayerPosition(char[,] matritrx)
        {
            int[] position = new int[2];
            for (int i = 0; i < matritrx.GetLength(0); i++)
            {
                for (int j = 0; j < matritrx.GetLength(0); j++)
                {
                    if (matritrx[i, j] == 'P')
                    {
                        position[0] = i;
                        position[1] = j;
                    }
                }
            }
            return position;
        }

        static void Fillmatrix(char[,] matritrx)
        {
            for (int i = 0; i < matritrx.GetLength(0); i++)
            {
                char[] matrixSymbols = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matritrx.GetLength(1); j++)
                {
                    matritrx[i, j] = matrixSymbols[j];
                }
            }
        }
    }
}
