using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.___SongQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songss = Console.ReadLine()
                .Split(", ")
                .ToArray();

            Queue<string> queue = new Queue<string>(songss);

            while (queue.Count > 0)
            {

                string commandd = Console.ReadLine();

                if (commandd == "Play")
                {
                    queue.Dequeue();
                }
                else if (commandd.Contains("Add"))
                {
                    string song = commandd.Substring(4);
                 
                    
                    if (!queue.Contains(song))
                    {
                        queue.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (commandd == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }


            }
           
                Console.WriteLine("No more songs!");
            








        }
    }
}
