using System;

class Program
{
    static int cursorX = 0; // позиция курсора по X
    static int cursorY = 0; // позиция курсора по Y
    static int canvasWidth = 10; // ширина холста
    static int canvasHeight = 10; // высота холста

    static void Main()
    {
        ConsoleKeyInfo keyInfo;

        do
        {
            Console.Clear();
            DrawCanvas(); // отрисовка холста
            MoveCursor(); // перемещение курсора

            keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                SetPixelColor(cursorX, cursorY, ConsoleColor.Red); // установка цвета пикселя
            }
        } while (keyInfo.Key != ConsoleKey.Escape);
    }

    static void DrawCanvas()
    {
        for (int y = 0; y < canvasHeight; y++)
        {
            for (int x = 0; x < canvasWidth; x++)
            {
                // если координаты совпадают с позицией курсора, рисуем символ "X"
                if (x == cursorX && y == cursorY)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("X");
                }
                else
                {
                    Console.ResetColor();
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    static void MoveCursor()
    {
        // перемещение курсора в зависимости от нажатой стрелки
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.UpArrow:
                if (cursorY > 0)
                    cursorY--;
                break;
            case ConsoleKey.DownArrow:
                if (cursorY < canvasHeight - 1)
                    cursorY++;
                break;
            case ConsoleKey.LeftArrow:
                if (cursorX > 0)
                    cursorX--;
                break;
            case ConsoleKey.RightArrow:
                if (cursorX < canvasWidth - 1)
                    cursorX++;
                break;
        }
    }

    static void SetPixelColor(int x, int y, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.BackgroundColor = color;
        Console.Write(" ");
    }
}