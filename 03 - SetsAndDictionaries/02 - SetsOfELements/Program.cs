using System;
using System.Collections.Generic;
using System.Linq;

namespace _02___SetsOfELements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] setsnum = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < setsnum[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < setsnum[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }

            HashSet<int> result = new HashSet<int>();
            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    result.Add(item);
                }
            }

            Console.WriteLine(String.Join(" ", result));

        }
    }
}
