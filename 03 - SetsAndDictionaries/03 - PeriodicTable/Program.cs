using System;
using System.Collections.Generic;

namespace _03___PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SortedSet<string> chemicalElements = new SortedSet<string>();
            for (int i = 0; i < num; i++)
            {
                string[] elements = Console.ReadLine().Split();
                foreach (var element in elements)
                {
                    chemicalElements.Add(element);
                }
            }

            Console.WriteLine(String.Join(' ', chemicalElements));

        }
    }
}
