namespace Множество_чисел2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите множество чисел: ");
            Console.WriteLine($"Сумма: {Console.ReadLine().Split().Sum(int.Parse)}");
            Console.ReadKey();
        }
    }
}