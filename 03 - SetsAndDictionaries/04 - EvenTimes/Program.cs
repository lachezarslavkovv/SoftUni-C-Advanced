using System;
using System.Collections.Generic;

namespace _04___EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
          
            Dictionary<int, int> numberDictionary = new Dictionary<int, int>();

            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numberDictionary.ContainsKey(number))
                {
                    numberDictionary.Add(number, 1);
                }
                else
                {
                    numberDictionary[number]++;
                }
            }

            foreach (var numb in numberDictionary)
            {
                if (numb.Value%2==0)
                {
                    Console.WriteLine(numb.Key);
                    break;
                }
            }



        }
    }
}
