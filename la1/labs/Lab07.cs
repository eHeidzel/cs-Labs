using System;
using System.Text.RegularExpressions;

namespace labs
{
    internal class Lab07
    {
        public static void Task1()
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            
            Regex pattern = new Regex(@"([А-Я]|[A-Z])\w+");

            foreach (var match in pattern.Matches(s))
                Console.WriteLine(match);
        }
    }
}
