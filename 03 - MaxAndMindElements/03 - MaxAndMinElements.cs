using System;
using System.Collections.Generic;
using System.Linq;

namespace _03___MaxAndMindElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int queriesNum = int.Parse(Console.ReadLine());

            Stack<int> stackd = new Stack<int>();

            for (int i = 0; i < queriesNum; i++)
            {
                int[] inputNums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int comandd = inputNums[0];

                if (comandd == 1)
                {
                    stackd.Push(inputNums[1]);
                }
                else
                {
                    if (stackd.Count > 0)
                    {
                        if (comandd == 2)
                        {
                            stackd.Pop();
                        }
                        else if (comandd == 3)
                        {
                            Console.WriteLine(stackd.Max());
                        }
                        else if (comandd == 4)
                        {
                            Console.WriteLine(stackd.Min());
                        }
                    }
                }
            }
            Console.WriteLine(String.Join( ", ",stackd));



        }
    }
}
