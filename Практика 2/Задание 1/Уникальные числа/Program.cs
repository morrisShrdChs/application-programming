using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> numbers = new HashSet<int>();

        while (true)
        {
            Console.WriteLine("Введите число (для выхода введите пустую строку):");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                break;

            int number;
            if (int.TryParse(input, out number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
            }
        }

        Console.WriteLine("Уникальные числа, которые были введены:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
