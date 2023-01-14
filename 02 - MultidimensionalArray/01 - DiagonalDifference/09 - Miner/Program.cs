using System;

namespace _09___Miner
{
    internal class Program
    {
        static void Main()
        {
            int nubmberMatrix = int.Parse(Console.ReadLine());
            string[] orders = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            char[,] matrirtx = new char[nubmberMatrix, nubmberMatrix];
            InputMatrix(matrirtx);
            int[] startNumbers = FindStartPosition(matrirtx);
            int startRow = startNumbers[0];
            int startCol = startNumbers[1];
            int coalCounter = 0;
            int maxCoal = MaxCoal(matrirtx);

            for (int i = 0; i < orders.Length; i++)
            {
                string order = orders[i];
                string[] resultInMining = new string[3];
                 resultInMining = Move(matrirtx, order, startRow, startCol);
                string item = resultInMining[0];
                int row = int.Parse(resultInMining[1]);
                int col = int.Parse(resultInMining[2]);
                startRow = row;
                startCol = col;

                if (item =="c")
                {
                    coalCounter++;
                    matrirtx[row, col] = '*';
                    if (coalCounter==maxCoal)
                    {
                        Console.WriteLine($"You collected all coals! ({startRow}, {col})");
                        return;
                    }
                }
                else if (item=="e")
                {
                    Console.WriteLine("Game over! ({0}, {1})", startRow, startCol);
                    return;
                }                
            }
            Console.WriteLine($"{maxCoal-coalCounter} coals left. ({startRow}, {startCol})");
            

        }

         static int MaxCoal(char[,] matrirtx)
        {
            int coal = 0;
            for (int i = 0; i < matrirtx.GetLength(0); i++)
            {
                for (int j = 0; j < matrirtx.GetLength(1); j++)
                {
                    if (matrirtx[i, j] == 'c')
                    {
                        coal++;
                    }                    
                }
            }
            return coal;

        }

         static string[] Move(char[,] matrirtx, string orders, int startRow, int startCol)
        {
            bool checkPossibleMove = false;
            char item = '*';
            string[] outpt = new string[3];

            if (orders == "up")
            {
                startRow--;
                checkPossibleMove = CheckAllowedPosition(matrirtx, startRow, startCol);
                if (!checkPossibleMove)
                {
                    startRow++;
                }
            }
            else if (orders == "down")
            {
                startRow++;
                checkPossibleMove = CheckAllowedPosition(matrirtx, startRow, startCol);
                if (!checkPossibleMove)
                {
                    startRow--;
                }
            }
            else if (orders == "left")
            {
                startCol--;
                checkPossibleMove = CheckAllowedPosition(matrirtx, startRow, startCol);
                if (!checkPossibleMove)
                {
                    startCol++;
                }
            }
            else if (orders == "right")
            {
                startCol++;
                checkPossibleMove = CheckAllowedPosition(matrirtx, startRow, startCol);
                if (!checkPossibleMove)
                {
                    startCol--;
                }
            }
            item = CheckItemInPostin(matrirtx, startRow, startCol);
            outpt[0] = item.ToString();
            outpt[1] = startRow.ToString() ;
            outpt[2] = startCol.ToString();

            return outpt;

        }

         static char CheckItemInPostin(char[,] matrirtx, int startRow, int startCol)
        {
            char inHolecontent = '*';
            if (matrirtx[startRow, startCol] == 'c')
            {
                inHolecontent = 'c';
            }
            else if (matrirtx[startRow, startCol] == 'e')
            {
                inHolecontent = 'e';
            }
            return inHolecontent;
        }

         static bool CheckAllowedPosition(char[,] matrirtx, int startRow, int startCol)
        {
            bool IsInField = false;
            if (startRow >= 0 && startRow < matrirtx.GetLength(0) && startCol >= 0 && startCol < matrirtx.GetLength(1))
            {
                IsInField = true;
            }
            return IsInField;
        }

         static int[] FindStartPosition(char[,] matrirtx)
        {
            int[] start = new int[2];

            for (int i = 0; i < matrirtx.GetLength(0); i++)
            {
                for (int j = 0; j < matrirtx.GetLength(1); j++)
                {
                    if (matrirtx[i, j] == 's')
                    {
                        start[0] = i;
                        start[1] = j;

                        break;
                    }
                }

            }
            return start;
        }
         static void InputMatrix(char[,] matrirtx)
        {
            for (int i = 0; i < matrirtx.GetLength(0); i++)
            {
                string[] inpSymbols = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                char[] symb = new char[inpSymbols.Length];

                for (int j = 0; j < inpSymbols.Length; j++)
                {
                    symb[j] = char.Parse(inpSymbols[j]);
                }                

                for (int j = 0; j < matrirtx.GetLength(1); j++)
                {
                    matrirtx[i, j] = symb[j];
                }
            }
        }
    }
}
