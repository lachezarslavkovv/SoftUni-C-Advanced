using System;
using System.Collections.Generic;

namespace _06___Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobeDictionary = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < number; i++)
            {
                string[] delimeters = { " -> ", "," };
                string[] inputDress = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
                string colour = inputDress[0];
                for (int j = 1; j < inputDress.Length ; j++)
                {
                    string dress = inputDress[j];

                    if (!wardrobeDictionary.ContainsKey(colour))
                    {
                        wardrobeDictionary.Add(colour, new Dictionary<string, int>());
                        wardrobeDictionary[colour].Add(dress, 1);
                    }
                    else
                    {
                        if (!wardrobeDictionary[colour].ContainsKey(dress))
                        {
                            wardrobeDictionary[colour].Add(dress,1);
                        }
                        else
                        {
                            wardrobeDictionary[colour][dress]++;
                        }
                    }
                }
            }

            string[] chosenclothes = Console.ReadLine().Split();
            string chosenColour = chosenclothes[0];
            string chosenDress = chosenclothes[1];



            foreach (var colourKey in wardrobeDictionary)
            {
                Console.WriteLine($"{colourKey.Key} clothes:");
                foreach (var dress in colourKey.Value)
                {
                    if (colourKey.Key == chosenColour && dress.Key == chosenDress)
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value}");
                    }

                }

            }
        }

      
    }
}
