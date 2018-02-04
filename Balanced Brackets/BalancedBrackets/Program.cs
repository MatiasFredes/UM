using System;
using Stack;

namespace BalancedBrackets
{
   public static class Program
    {
        public static Stack<char> stack {get;set;}
        public static Stack<char> stackAux {get;set;}
         private static int GetBracketValue(char bracket)
         {
             switch (bracket)
             {
                 case '[': return 1;
                 case '{': return 2;
                 case '(': return 3;
                 case ']': return -1;
                 case '}': return -2;
                 case ')': return -3;

                 default: return 0;
             }
         }
        static void Main(string[] args)
        {
            string s = "{[(])}";
            
            Console.WriteLine(s);
            Console.WriteLine(IsBalanced(s));
        }

        private static void FillStack(char[] brackets)
        {
            foreach (char item in brackets)
            {
                stack.Push(item);
            }
        }
        private static bool AmountIsEven()
        {
            return stack.Count % 2 == 0;
        }

        public static string IsBalanced(string s)
        {
            stack = new Stack<char>();
            stackAux = new Stack<char>();
            bool isBalanced = false;
            FillStack(s.ToCharArray());
            if(!AmountIsEven())
                return "NO";
            else
            {
                 while(stack.Count > 0)
                {
                    char firstElement = stack.Pop();

                    while(stack.Count != 1)
                    {
                        char element = stack.Pop();
                        stackAux.Push(element);
                    }

                    char lastElement = stack.Pop();
                    isBalanced = (GetBracketValue(lastElement) + GetBracketValue(firstElement)) == 0;
                    if(!isBalanced)
                        return "NO";

                    while(stackAux.Count > 0)
                    {
                        char element = stackAux.Pop();
                        stack.Push(element);
                    }
                }
            }
            
            return "YES";
        }
    }
   
}
