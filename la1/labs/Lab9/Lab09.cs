using System;

namespace labs
{
    internal class Lab09
    {
        public static void Task1()
        {
            Console.WriteLine("Изначальный прямоугольник");
            Rectangle rectangle = new Rectangle(2, 3);
            rectangle.ShowSides();

            Console.WriteLine("Умножение сторон на 2");
            rectangle *= 2;
            rectangle.ShowSides();

            Console.WriteLine($"Является ли прямоугольник квадратом? {rectangle.IsSquare}");
            rectangle[0] = 6;
            Console.WriteLine("Прямоугольник после присвоения a = 6");
            rectangle.ShowSides();

            Console.WriteLine("Является ли квадрат прямоугольником при помощи переопределения true и false");
            if (rectangle)
                Console.WriteLine("Прямоугольник является квадратом");
            else 
                Console.WriteLine("Прямоугольник не является квадратом");

            Console.WriteLine("Стороны прямоугольника после ++");
            rectangle++;
            rectangle.ShowSides();
            Console.WriteLine("Стороны прямоугольника после --");
            rectangle--;
            rectangle.ShowSides();
            Console.WriteLine($"Периметр прямоугольника {rectangle.GetPerimetr()}");
            Console.WriteLine($"Площадь прямоугольника {rectangle.GetSquare()}");
        }
    }
}
