using System;

namespace labs
{
    internal class Lab02
    {
        public static void Task1()
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x < 1)
            {
                Console.WriteLine("Корень из отрицательного числа не извлекается");
                return;
            }
            Console.WriteLine($"y = {Math.Sqrt(x * x - 1)}");
        }

        public static void Task2()
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());

            if ((y <= 0) && (x <= 0) && y >= x / -7 - 1)
            {
                if (y == 0 || x == 0 || y == x / -7 - 1)
                    Console.WriteLine("На границе");
                else 
                    Console.WriteLine("Внутри");
            }
            else
                Console.WriteLine("Вне области");
            // y < 0
            // x < -7
            // (0, -1) (-7, 0)
            // (x-0)/(x2-x1) = (y-y1)/(y2-y1)
        }

        public static void Task3()
        {
            Console.WriteLine("Введите номер");
            switch (Console.ReadLine())
            {
                case "6":
                    Console.WriteLine("Шестёрка");
                    break;
                case "7":
                    Console.WriteLine("Семёрка");
                    break;
                case "8":
                    Console.WriteLine("Восьмёрка");
                    break;
                case "9":
                    Console.WriteLine("Девятка");
                    break;
                case "10":
                    Console.WriteLine("Десятка");
                    break;
                case "11":
                    Console.WriteLine("Валет");
                    break;
                case "12":
                    Console.WriteLine("Дама");
                    break;
                case "13":
                    Console.WriteLine("Король");
                    break;
                case "14":
                    Console.WriteLine("Туз");
                    break;
                default:
                    Console.WriteLine("Нет такой карты");
                    break;
            }
        }
    }
}
