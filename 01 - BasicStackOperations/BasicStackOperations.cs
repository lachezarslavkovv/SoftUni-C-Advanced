using System;
using System.Collections.Generic;
using System.Linq;

namespace _01___BasicStackOperations
{
    internal class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numInStack = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numInStack);
            int numToPop = numbers[1];
            int numToCheck = numbers[2];


            for (int i = 0; i < numToPop; i++)
            {
                if (stack.Count>0)
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
