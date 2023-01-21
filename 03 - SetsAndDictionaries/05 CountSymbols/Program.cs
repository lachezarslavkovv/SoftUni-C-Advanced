using System;
using System.Collections.Generic;

namespace _05_CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] symbols = input.ToCharArray();

            SortedDictionary<char, int> symbolsDictionary = new SortedDictionary<char, int>();
            
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbolsDictionary.ContainsKey(symbols[i]))
                {
                    symbolsDictionary[symbols[i]]++;
                }
                else
                {
                    symbolsDictionary.Add(symbols[i], 1);
                }
            }
            foreach (var item in symbolsDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
