using System;

namespace labs
{
    internal class Lab03
    {
        private static double a, b;

        private static void ReadNums()
        {
            Console.Write("a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            b = Convert.ToInt32(Console.ReadLine());
        }

        public static void Task1()
        {
            ReadNums();
            for (int i = (int)a; i <= (int)b; i++)
            {
                if (i % 10 % 2 == 0)
                    Console.WriteLine(i);
            }

            Console.WriteLine();
        }

        public static void Task3()
        {
            ReadNums();
            Console.Write("h= ");
            double h = Convert.ToDouble(Console.ReadLine());
            double x = a;

            while (x < b) 
            {
                Console.WriteLine($"x = {x}; y = {Math.Round(Solve(x), 2)}");
                x += h;
            }
        }

        private static double Solve(double x)
        {
            if (x < 10)
                return 0;
            else if (x > a)
                return (x - a) / (x + a);
            else
                return 1;
        }

        public static void Task2()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine();
            }
        }
    }
}
