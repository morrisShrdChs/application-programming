using System;
using System.Runtime.InteropServices;

namespace Операции_с_числами
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double answer = 0;

            Console.Write("Введите число x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите необходимую операцию(+, -, /, *, %): ");
            char k = Convert.ToChar(Console.ReadLine());

            switch (k)
            {
                case '+':
                    answer = x + y;
                    break;
                case '-':
                    answer = x - y;
                    break;
                case '*':
                    answer = x * y;
                    break;
                case '/':
                    answer = x / y;
                    break;
                case '%':
                    answer = x % y;
                    break;
            }

            Console.WriteLine($"Результат {x} {k} {y} = {answer}");
            Console.ReadLine();
        }
    }
}