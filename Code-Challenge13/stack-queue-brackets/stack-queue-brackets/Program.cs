using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue_brackets
{
    public class Program
    {
        static void Main(string[] args)
        {

            string input = "()";

            Console.WriteLine(ValidBrackets("()")); // true
            Console.WriteLine(ValidBrackets("()[]{}")); // true
            Console.WriteLine(ValidBrackets("(]")); // false
            Console.WriteLine(ValidBrackets("([)]")); // false
            Console.WriteLine(ValidBrackets("()[[Extra Characters]]")); // true
            Console.WriteLine();
            Console.ReadKey();

        }

        public static bool ValidBrackets(String input)
        {
            Stack stack = new();
            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                if (c == ')' || c == '}' || c == ']')
                {
                    char x;
                    if (c == ')')
                    {
                        x = '(';
                    }
                    else if (c == '}')
                    {
                        x = '{';
                    }
                    else
                    {
                        x = '[';
                    }
                    if ((char)stack.Peek() == x)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }



}