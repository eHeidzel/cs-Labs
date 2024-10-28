using System;

namespace labs
{
    internal class Lab04
    {
        public static void Task1()
        {
            Console.Write("a = ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = Double.Parse(Console.ReadLine());
            double aRes = Solve(a), bRes = Solve(b);

            if (aRes > bRes)
                Console.WriteLine($"Значение больше в точке {a} \n\tf(a) = {aRes}");
            else 
                Console.WriteLine($"Значение больше в точке {b} \n\tf(b) = {bRes}");
        }

        private static double Solve(double x) => Math.Pow(x, 3) - Math.Sin(x);

        public static void Task2()
        {
            Console.WriteLine("Введите длину последовательности");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
                Console.WriteLine($"Наименьшая цифра в числе: {FindMinNum(int.Parse(Console.ReadLine()))}");
        }

        private static int FindMinNum(int num)
        {
            int min = int.MaxValue;

            if (num == 0)
                return 0;

            while (num > 0)
            {
                if (num % 10 < min)
                    min = num % 10;
                num = num / 10;
            }

            return min;
        }
    }
}
