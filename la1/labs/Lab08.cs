using System;

namespace labs
{
    struct Government
    {
        public readonly string Name;
        public readonly string Capital;
        public readonly int Popultaion;
        public readonly double Square;

        public Government(string name, string capital, int population, double square)
        {
            Name = name;
            Capital = capital;
            Popultaion = population;
            Square = square;
        }

        public override string ToString() => $"  Название:{Name}\n  Столица:{Capital}\n  Население:{Popultaion}\n  Площадь:{Square}";
    }

    internal class Lab08
    {
        public static void Task1()
        {
            string name, capital;
            int population;
            double square;
            Console.WriteLine("Введите кол-во элементов");
            int n = Convert.ToInt32(Console.ReadLine());

            Government[] governments = new Government[n];

            //чтение
            Console.WriteLine("Введите данные");
            for (int i = 0; i < governments.Length; i++)
            {
                Console.Write("Название = ");
                name = Console.ReadLine();
                Console.Write("Столица = ");
                capital = Console.ReadLine();
                Console.Write("Численность населения = ");
                population = Convert.ToInt32(Console.ReadLine());
                Console.Write("Площадь = ");
                square = Convert.ToDouble(Console.ReadLine());
                governments[i] = new Government(name, capital, population, square);
                Console.WriteLine();
            }

            Console.WriteLine("Госудраства после ввода");
            ShowSavedGovernments(governments);

            // удаление
            Console.WriteLine("Введите минимальное населедние государства (все, у кого меньше, будут удалены)");
            int minPopulation = Convert.ToInt32(Console.ReadLine());
            int deleted = 0;


            for (int i = 0; i < governments.Length; i++)
            {
                for (int j = 0; j < governments.Length; j++)
                {
                    if (governments[j].Popultaion < minPopulation)
                        for (int k = j; k < governments.Length - deleted; k++)
                        {
                            if (k == governments.Length - deleted - 1)
                                deleted++;
                            else
                                governments[k] = governments[k + 1];
                        }
                }
            }

            Array.Resize(ref governments, governments.Length - deleted);

            Console.WriteLine("Государства после удаление");
            ShowSavedGovernments(governments);

            // добавление
            Console.WriteLine("Введите номер элемента, куда хотите вставить элемент");
            int indexToAdd = Convert.ToInt32(Console.ReadLine());

            Array.Resize(ref governments, governments.Length + 1);

            for (int i = indexToAdd; i < governments.Length - 1; i++)
                governments[i + 1] = governments[i];

            Console.WriteLine("Введите данные");

            Console.Write("Название = ");
            name = Console.ReadLine();
            Console.Write("Столица = ");
            capital = Console.ReadLine();
            Console.Write("Численность населения = ");
            population = Convert.ToInt32(Console.ReadLine());
            Console.Write("Площадь = ");
            square = Convert.ToDouble(Console.ReadLine());
            governments[indexToAdd] = new Government(name, capital, population, square);
            Console.WriteLine();

            Console.WriteLine("Государства после добавления");
            ShowSavedGovernments(governments);
        }

        private static void ShowSavedGovernments(Government[] governments)
        {
            for (int i = 0; i < governments.Length; i++)
                Console.WriteLine($"{i}\n{governments[i]}");
        }
    }
}
