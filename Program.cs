using System;
using System.Collections.Generic;
using System.Linq;

namespace _01___BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int numPop = inputNums[1];
            int numToCheck = inputNums[2];

            int[] numToStack = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numToStack);

            for (int i = 0; i < numPop; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    break;
                }
            }

            if (stack.Contains(numToCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count>0)
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }


        }
    }
}
