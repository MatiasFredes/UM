using System;
using Stack;

namespace RPN
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackIntegers = new Stack<int>();
            
            foreach (string item in args)
            {
                try
                {
                    int number = Convert.ToInt16(item);
                    Console.WriteLine("El elemento es el " + number);
                    stackIntegers.Push(number);
                    Console.WriteLine(number);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Es el simbolo: " + item);
                    // saco los ultimos dos elementos de la pila
                    int operando_1 = stackIntegers.Pop();
                    int operando_2 = stackIntegers.Pop();
                    int resultado = ResultadoOperacion(operando_1, operando_2, item);
                    stackIntegers.Push(resultado);
                }
              
            } 

            Console.WriteLine("El resultado es: " + stackIntegers.Pop());
            
        }

        private static int ResultadoOperacion(int operando_1, int operando_2, string operacion)
        {
            switch (operacion)
            {
                case "+": return operando_1 + operando_2;
                case "-": return operando_1 - operando_2;
                case "*": return operando_1 * operando_2;
                case "/": return operando_1 / operando_2;

                default: throw new Exception("El operando es inválido");
            }
        }
    }
}
