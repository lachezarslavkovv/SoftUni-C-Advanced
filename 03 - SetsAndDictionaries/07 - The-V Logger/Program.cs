using System;
using System.Collections.Generic;
using System.Linq;

namespace _07___The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggerDictionary
                = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            while (text != "Statistics")
            {
                string[] textParts = text.Split();
                string vloger = textParts[0];
                string command = textParts[1];
                string member = textParts[2];

                if (command == "joined")
                {
                    if (!vloggerDictionary.ContainsKey(vloger))
                    {
                        vloggerDictionary.Add(vloger, new Dictionary<string, HashSet<string>>());
                        vloggerDictionary[vloger].Add("followers", new HashSet<string>());
                        vloggerDictionary[vloger].Add("following", new HashSet<string>());
                    }
                }
                else if (command == "followed")
                {

                    if (vloggerDictionary.ContainsKey(vloger) && vloggerDictionary.ContainsKey(member) && vloger != member)
                    {
                        vloggerDictionary[vloger]["following"].Add(member);
                        vloggerDictionary[member]["followers"].Add(vloger);
                    }
                }
                text = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggerDictionary.Count} vloggers in its logs.");

            int number = 1;

            foreach (var vloger in vloggerDictionary.OrderByDescending(v => v.Value["followers"].Count).ThenBy(
                v => v.Value["following"].Count))
            {
                Console.WriteLine($"{number}. {vloger.Key} : {vloger.Value["followers"].Count} followers, " +
                    $"{vloger.Value["following"].Count} following");
                if (number == 1)
                {
                    foreach (var follower in vloger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                number++;
            }
        }
    }
}

