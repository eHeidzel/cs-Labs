using System;
using System.Linq;
using System.Text;

namespace labs
{
    internal class Lab06
    {
        public static void AddedTask1()
        {
            string poems = "тучки небесные вечные странники";
            char[] div = {' '}; //создаем массив разделителей
            // Разбиваем строку на части,
            string[] parts = poems.Split(div);
            Console.WriteLine("Результат разбиения строки на части:");
            for (int i = 0; i < parts.Length; i++)
            { 
                Console.WriteLine(parts[i]);
            }
            // собираем эти части в одну строку, в качестве разделителя используем
            // символ |
            string whole = String.Join(" | ", parts.Reverse());
            Console.WriteLine("Результат сборки:");
            Console.WriteLine(whole);
        }

        public static void AddedTask2()
        {
            Console.WriteLine("Введите строку:");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < a.Length;) //удаляем из строк все знаки пунктуации
            {
                if (i != 0 && a[i] == ' ' && a[i-1] == ' ')
                    a.Remove(i, 1);
                else if (char.IsPunctuation(a[i]))
                {
                    a.Remove(i, 1);
                }
                else ++i;
            }
            //преобразуем объект StringBuilder к типу string, и разбиваем его на массив слов
            string[] s = a.ToString().Split(' ');
            Console.WriteLine("Искомые слова:");
            //перебираем все слова в массиве слов и выводим на экран те, которые
            //начинаются и заканчиваются на одну и туже букву
            foreach (string str in s)
            {
                if (str.Length == 0)
                    continue;
                if (str[0] == str[str.Length - 1])
                    Console.WriteLine(str);
            }
        }

        public static void Task1()
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine().ToLower();

            Console.WriteLine("Введите первый символ");
            char a = Console.ReadKey(false).KeyChar; //чтение символа
            Console.WriteLine();

            Console.WriteLine("Введите второй символ");
            char b = Console.ReadKey(false).KeyChar;
            Console.WriteLine();

            int aCount = 0;
            int bCount = 0;

            for (int i = 0; i < s.Length; i++) // подсчитывание символов
            {
                if (s[i] == a)
                    aCount++;
                if (s[i] == b)
                    bCount++;
            }

            // определение максимального и корректный вывод
            char sym = aCount > bCount ? a : b;

            if (aCount == 0 && bCount == 0)
                Console.WriteLine("В строке нет введённых символов");
            else if (aCount == bCount)
                Console.WriteLine("Эти символы встречаются с одинаковой частотой");
            else
                Console.WriteLine($"В строке чаще встречается символ {sym}");
        }

        public static void Task2()
        {
            Console.WriteLine("Введите строку");
            StringBuilder sb = new StringBuilder(Console.ReadLine());

            Console.WriteLine("Введите подстроку");
            StringBuilder substrSB = new StringBuilder(Console.ReadLine());
            string sb1time = substrSB.ToString();
            substrSB.Append(sb1time);            

            sb.Replace(sb1time, substrSB.ToString());
            Console.WriteLine(sb);
        }

        public static void Task3()
        {
            //выделяется меньше памяти, нам не нужно изменять строку
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();

            string[] words = s.Split();

            foreach (var word in words)
                for (int i = 0; i < word.Length; i++)
                    if (char.IsDigit(word[i]))
                    {
                        Console.WriteLine(word);
                        break;
                    }
        }
    }
}
