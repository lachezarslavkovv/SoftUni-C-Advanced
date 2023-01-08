using System;
using System.Collections.Generic;

namespace _08___Balanced_Parantheses
{
    class BalancedParanthesess
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArr = input.ToCharArray();

            Stack<char> stack = new Stack<char>();
            bool balanced = true;

            for (int i = 0; i < inputArr.Length; i++)
            {
                char currentElement = inputArr[i];
                if (currentElement == '[' || currentElement == '{' || currentElement == '(')
                {
                    stack.Push(currentElement);
                }
                else
                {
                    if (stack.Count== 0)
                    {
                        balanced = false;
                        break;
                    }
                    if (currentElement == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else if (currentElement == '}' && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else if (currentElement == ']' && stack.Peek()=='[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        balanced = false;
                        break;
                    }
                }
            }

            if (balanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
