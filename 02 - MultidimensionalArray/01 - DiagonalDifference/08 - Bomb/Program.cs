using System;
using System.Linq;

namespace _08___Bomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[numMatrix, numMatrix];
            InputMatrixNums(matrix);
            char[] deliminters = { ' ', ',' };
            int[] bombsNumber = Console.ReadLine().Split(deliminters, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int liveCells = 0;
            int sum = 0;
            for (int i = 0; i < bombsNumber.Length; i += 2)
            {
                int bombRow = bombsNumber[i];
                int bombCol = bombsNumber[i + 1];
                ReduseBombPower(matrix, bombRow, bombCol);

            }
            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    sum += item;
                    liveCells++;
                }

            }
            Console.WriteLine($"Alive cells: {liveCells}");
            Console.WriteLine($"Sum: {sum}");
            PrintMatrix(matrix);
        }
        private static void PrintMatrix(int[,] matritr)
        {
            for (int i = 0; i < matritr.GetLength(0); i++)
            {
                for (int j = 0; j < matritr.GetLength(1); j++)
                {
                    Console.Write("{0}{1}", matritr[i, j], j == matritr.GetLength(1) - 1 ? '\n' : ' ');
                }
            }
        }

        private static void ReduseBombPower(int[,] matritr, int bombRowo, int bombColo)
        {
            int bombPower = matritr[bombRowo, bombColo];
            bool isInMatrix = false;
            for (int i = bombRowo - 1; i <= bombRowo + 1; i++)
            {
                for (int j = bombColo - 1; j <= bombColo + 1; j++)
                {
                    isInMatrix = CheckPosition(matritr, i, j);
                    if (isInMatrix)
                    {
                        if (matritr[i,j]>0)
                        {
                        matritr[i, j] -= bombPower;

                        }
                    }
                }

            }

        }

        private static bool CheckPosition(int[,] matritr, int i, int j)
        {
            bool isInMatrix = false;
            if (i >= 0 && i <= matritr.GetLength(0) - 1)
            {
                if (j >= 0 && j <= matritr.GetLength(1) - 1)
                {
                    isInMatrix = true;
                }
            }
            return isInMatrix;


        }

        private static void InputMatrixNums(int[,] matritr)
        {

            for (int i = 0; i < matritr.GetLength(0); i++)
            {
                int[] numberts = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matritr.GetLength(1); j++)
                {
                    matritr[i, j] = numberts[j];
                }
            };
        }
    }
}
