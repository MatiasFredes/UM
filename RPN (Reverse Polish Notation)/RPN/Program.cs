using System;
using Stack;

namespace RPN
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackIntegers = new Stack<int>();

            foreach (var item in args)
            {
               Console.WriteLine(item);
            } 
            
        }
    }
}
