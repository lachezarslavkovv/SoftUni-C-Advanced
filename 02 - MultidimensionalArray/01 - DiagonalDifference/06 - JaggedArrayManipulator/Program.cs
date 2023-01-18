using System;
using System.Linq;

namespace _06___JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayNum = int.Parse(Console.ReadLine());
            int[][] jagged = new int[arrayNum][];

            for (int i = 0; i < jagged.Length; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[i] = new int[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    jagged[i][j] = input[j];
                }
            }

            for (int i = 0; i < jagged.Length - 1; i++)
            {
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    jagged[i] = jagged[i].Select(k => k * 2).ToArray();
                    jagged[i + 1] = jagged[i + 1].Select(k => k * 2).ToArray();
                }
                else
                {
                    jagged[i] = jagged[i].Select(k => k / 2).ToArray();
                    jagged[i + 1] = jagged[i + 1].Select(k => k / 2).ToArray();
                }

            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string cmnd = commandArr[0];

                int row = int.Parse(commandArr[1]);
                int col = int.Parse(commandArr[2]);
                int value = int.Parse(commandArr[3]);

                if (cmnd == "Add")
                {
                    if (row >= 0 && row < jagged.Length)
                    {
                        if (col >= 0 && col < jagged[row].Length) 
                        {
                            jagged[row][col] += value;
                        }
                    }
                }
                else
                {
                    if (cmnd == "Subtract")
                    {
                        if (row >= 0 && row < jagged.Length)
                        {
                            if (col >= 0 && col < jagged[row].Length) 
                            {
                                jagged[row][col] -= value;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j]);
                    if (j < jagged[i].Length - 1)
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
