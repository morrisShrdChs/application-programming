using System;

struct Rectangle
{
    public int X;
    public int Y;
    public int Width;
    public int Height;
}

class Program
{
    static Rectangle ReadRectangle()
    {
        Console.WriteLine("Введите координаты и размеры прямоугольника:");

        Rectangle rectangle;
        rectangle.X = int.Parse(Console.ReadLine());
        rectangle.Y = int.Parse(Console.ReadLine());
        rectangle.Width = int.Parse(Console.ReadLine());
        rectangle.Height = int.Parse(Console.ReadLine());

        return rectangle;
    }

    static Rectangle IntersectRectangles(Rectangle rectangle1, Rectangle rectangle2)
    {
        Rectangle intersection;

        intersection.X = Math.Max(rectangle1.X, rectangle2.X);
        intersection.Y = Math.Max(rectangle1.Y, rectangle2.Y);
        int right1 = rectangle1.X + rectangle1.Width;
        int right2 = rectangle2.X + rectangle2.Width;
        int bottom1 = rectangle1.Y + rectangle1.Height;
        int bottom2 = rectangle2.Y + rectangle2.Height;
        intersection.Width = Math.Max(0, Math.Min(right1, right2) - intersection.X);
        intersection.Height = Math.Max(0, Math.Min(bottom1, bottom2) - intersection.Y);

        return intersection;
    }

    static int CalculateArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }

    static void Main(string[] args)
    {
        ///Console.WriteLine("Введите информацию о пересекающихся прямоугольниках (ввод заканчивается при вводе стороны равной 0):");

        Rectangle intersection = new Rectangle();
        Rectangle rectangle;

        while (true)
        {
            rectangle = ReadRectangle();

            if (rectangle.Width == 0 || rectangle.Height == 0)
                break;

            if (intersection.Width == 0 || intersection.Height == 0)
            {
                intersection = rectangle;
            }
            else
            {
                intersection = IntersectRectangles(intersection, rectangle);
            }
        }

        int area = CalculateArea(intersection);
        Console.WriteLine("Площадь пересечения прямоугольников: " + area);
    }
}
