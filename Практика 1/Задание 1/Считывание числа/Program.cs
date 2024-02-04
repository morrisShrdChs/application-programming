using System.ComponentModel;

namespace Считывание_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сумма чисел a + b = {(a + b)}");
        }
    }
}