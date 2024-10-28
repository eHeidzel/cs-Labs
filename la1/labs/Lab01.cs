using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs
{
    internal class Lab01
    {
        public static int a, b, c;

        public static void ReadNums(int count = 3)
        {
            Console.Write("a= ");
            a = Convert.ToInt32(Console.ReadLine());
            if (count > 1)
            {
                Console.Write("b= ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            if (count > 2)
            {
                Console.Write("c= ");
                c = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void Task1()
        {
            ReadNums();
            Console.WriteLine($"{a}+{b}+{c}={a + b + c}");
        }


        public static void Task2()
        {
            ReadNums(2);
            Console.WriteLine($"Гипотенуза --- {Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))}");
        }

        public static void Task3()
        {
            ReadNums(1);
            string res = a % 10 == a / 10 % 10 ?
                "Да, данное число включает одинаковые цифры" :
                "Нет, в данном числе цифры разные";
            Console.WriteLine(res);
        }
    }
}
