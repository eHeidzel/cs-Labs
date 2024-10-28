using System;
using System.IO;

namespace labs
{
    internal class Lab10
    {
        public static void Task1()
        {
            Console.WriteLine("Введите количество элементов");
            int n = Convert.ToInt32(Console.ReadLine());

            Edition[] editions = ReadEditions(n, "data.txt");

            Console.WriteLine("Текущие издания");
            foreach (var edition in editions)
            {
                edition.ShowInfo();
                Console.WriteLine();
            }

            Array.Sort(editions);

            Console.WriteLine("Отсортированные издания");
            foreach (var edition in editions)
            {
                edition.ShowInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Введите фамилию автора, издания которого вы хотите увидеть");
            string name = Console.ReadLine();
            foreach (var edition in editions)
            {
                if (!edition.IsDesired(name))
                    continue;

                edition.ShowInfo();
                Console.WriteLine();
            }
        }

        public static Edition[] ReadEditions(int n, string path)
        {
            Edition[] editions = new Edition[n];

            string text = File.ReadAllText(path).Replace("\r\n", "\n").Replace("@\n", "@");
            string[] edsLikeText = text.Split('@');

            for (int i = 0; i < editions.Length; i++)
            {
                string[] args = edsLikeText[i].Split('\n');
                editions[i] = ReadEdition(args[0], args);
                editions[i].ReadFromText(args);
            }

            return editions;
        }

        public static Edition ReadEdition(string type, string[] args)
        {
            switch (type)
            {
                case nameof(Article):
                    return new Article(args);
                case nameof(Book):
                    return new Book(args);
                case nameof(OnlineResource):
                    return new OnlineResource(args);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
