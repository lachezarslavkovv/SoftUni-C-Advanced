using System;
using System.Collections.Generic;

namespace _01___UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nameNumber = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < nameNumber; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
