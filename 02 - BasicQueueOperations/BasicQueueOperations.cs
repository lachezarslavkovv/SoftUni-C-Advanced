using System;
using System.Collections.Generic;
using System.Linq;

namespace _02___BasicQueueOperations
{
    internal class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int[] numInQueue = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(numInQueue);
            int numToPop = numbers[1];
            int numToCheck = numbers[2];


            for (int i = 0; i < numToPop; i++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Contains(numToCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count > 0)
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
