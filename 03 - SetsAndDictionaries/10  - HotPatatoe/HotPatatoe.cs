using System;
using System.Collections.Generic;

namespace _007.___Lecture___HotPatatoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            int number = int.Parse(Console.ReadLine());

            Queue<string> queuue = new Queue<string>(names);

            while (queuue.Count>1)
            {
                for (int i = 0; i < number-1; i++)
                {
                    string kid = queuue.Dequeue();
                    queuue.Enqueue(kid);
                }

                Console.WriteLine($"Removed {queuue.Dequeue()}");


            }
            Console.WriteLine($"Last is {queuue.Peek()}");



        }
    }
}
