using System;
using System.Collections.Generic;
using System.Linq;

namespace _04___FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orderNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queueu = new Queue<int>(orderNums);

            int maxOrder = queueu.Max();
            
            for (int i = 0; i < orderNums.Length; i++)
            {
                if (foodQuantity>queueu.Peek())
                {
                    foodQuantity-=queueu.Dequeue();
                }
                else
                {
                    break;
                }
            }

                Console.WriteLine(maxOrder);
            if (queueu.Count>0)
            {
                Console.WriteLine($"Orders left: {queueu.Sum()}");
            }
            else
            {
                Console.WriteLine("Order complete");
            }
        }
    }
}
