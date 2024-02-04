using System;
using System.Collections.Generic;

class Point
{
    public double X { get; private set; }
    public double Y { get; private set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void ShiftRandomly()
    {
        Random random = new Random();
        X += random.NextDouble() * 20 - 10;
        Y += random.NextDouble() * 20 - 10;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Point> points = new List<Point>();

        Console.Write("Введите количество точек: ");
        int count = int.Parse(Console.ReadLine());

        // Создание и сдвиг точек
        for (int i = 0; i < count; i++)
        {
            Point point = new Point(0, 0);
            point.ShiftRandomly();
            points.Add(point);
        }

        // Определение ограничивающего прямоугольника
        double minX = double.MaxValue;
        double maxX = double.MinValue;
        double minY = double.MaxValue;
        double maxY = double.MinValue;

        foreach (Point point in points)
        {
            if (point.X < minX)
                minX = point.X;
            if (point.X > maxX)
                maxX = point.X;
            if (point.Y < minY)
                minY = point.Y;
            if (point.Y > maxY)
                maxY = point.Y;
        }

        Console.WriteLine($"Координаты ограничивающего прямоугольника: ({minX}, {minY}), ({maxX}, {maxY})");

        // Изменение координат точки
        int pointIndex;
        do
        {
            Console.Write("Введите номер точки (или 0 для выхода): ");
            pointIndex = int.Parse(Console.ReadLine());

            if (pointIndex > 0 && pointIndex <= points.Count)
            {
                Point point = points[pointIndex - 1];
                point.ShiftRandomly();

                // Обновление ограничивающего прямоугольника
                minX = double.MaxValue;
                maxX = double.MinValue;
                minY = double.MaxValue;
                maxY = double.MinValue;

                foreach (Point p in points)
                {
                    if (p.X < minX)
                        minX = p.X;
                    if (p.X > maxX)
                        maxX = p.X;
                    if (p.Y < minY)
                        minY = p.Y;
                    if (p.Y > maxY)
                        maxY = p.Y;
                }

                Console.WriteLine($"Новые координаты ограничивающего прямоугольника: ({minX}, {minY}), ({maxX}, {maxY})");
            }
            else if (pointIndex != 0)
            {
                Console.WriteLine("Некорректный номер точки.");
            }
        } while (pointIndex != 0);
    }
}
