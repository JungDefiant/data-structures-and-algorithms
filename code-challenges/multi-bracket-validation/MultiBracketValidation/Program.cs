using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Channels;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{}{{}} Returns: " + MultiBracketValidation("{}{{}}"));
            Console.WriteLine("{}{Code}[Fellows](()) Returns: " 
                + MultiBracketValidation("{}{Code}[Fellows](())"));
            Console.WriteLine("(){}[[]] Returns: " + MultiBracketValidation("(){}[[]]"));
            Console.WriteLine("[({}] Returns: " + MultiBracketValidation("[({}]"));
        }

        public static bool MultiBracketValidation(string input)
        {
            char[] opening = new char[] { '{', '[', '(' };
            char[] closing = new char[] { '}', ']', ')' };
            List<char> emptyCharList = new List<char>();

            foreach (char c in input)
            {
                if (opening.Contains(c)) emptyCharList.Add(c);
                else if (closing.Contains(c))
                {
                    int indexMatch = Array.FindIndex(closing, ch => ch == c);
                    if (indexMatch == Array.FindIndex(opening, ch => ch == emptyCharList[emptyCharList.Count - 1]))
                    {
                        emptyCharList.RemoveAt(emptyCharList.Count - 1);
                    }
                    else return false;
                }
            }

            return true;
        }
    }
}
