using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.___FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rackCapacitty = int.Parse(Console.ReadLine());
            int rackNumbers = 1;
            int rackcap = rackCapacitty;

            Stack<int> sstack = new Stack<int>(clothes);


            while (sstack.Count>0)
            {
                if (rackCapacitty>=sstack.Peek())
                {
                    rackCapacitty -= sstack.Peek();
                    sstack.Pop();
                }
                else 
                {
                    rackNumbers++;
                    rackCapacitty = rackcap;
                    rackCapacitty -= sstack.Pop();
                }
                
               

            }

            Console.WriteLine(rackNumbers);

            











        }
    }
}
