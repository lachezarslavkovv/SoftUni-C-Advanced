using System;
using System.Linq;

namespace _06___Jaggedarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArr= new int[n][];
            ReadNumbersForArray(jaggedArr);
            OperationsWithJagged(jaggedArr);            
            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] commandElements = command.Split(' ');
                string commandOrder = commandElements[0];
                int commandRow = int.Parse(commandElements[1]);
                int commandCol = int.Parse(commandElements[2]);
                int commandValue = int.Parse(commandElements[3]);

                switch (commandOrder)
                {
                    case "Add":
                     if (commandRow >=0 && commandRow <= jaggedArr.Length && commandCol>=0 && commandCol < jaggedArr[commandRow].Length)
                        {
                            jaggedArr[commandRow][commandCol] += commandValue;
                        }
                        break;
                    case "Subtract":
                        if (commandRow >= 0 && commandRow <= jaggedArr.Length && commandCol >= 0 && commandCol < jaggedArr[commandRow].Length)
                        {
                            jaggedArr[commandRow][commandCol] -= commandValue;                            
                        }
                        break;
                }
                command = Console.ReadLine();        
            }
            PrintJagged(jaggedArr);

        }

        private static void PrintJagged(int[][] jaggedArr)
        {
            foreach (int[] rowo in jaggedArr)
            {
                Console.WriteLine(String.Join(' ',rowo));
            }
        }

        private static void OperationsWithJagged(int[][] jaggedArr)
        {
            for (int i = 0; i < jaggedArr.Length - 1; i++)
            {
                if (jaggedArr[i].Length == jaggedArr[i + 1].Length)
                {
                    jaggedArr[i]= jaggedArr[i].Select(el => el * 2).ToArray();
                    jaggedArr[i+1]= jaggedArr[i + 1].Select(el => el * 2).ToArray();
                }
                else
                {
                    jaggedArr[i] = jaggedArr[i].Select(el => el / 2).ToArray();
                    jaggedArr[i+1] = jaggedArr[i + 1].Select(el => el / 2).ToArray();
                }
            }
        }

        static void ReadNumbersForArray(int[][] jaggedArr)
        {
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArr[i] = new int[numbers.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    jaggedArr[i][j] = numbers[j];
                }
            }
        }
    }
}
