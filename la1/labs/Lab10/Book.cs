using System;

namespace labs
{
    internal class Book : Edition
    {
        public string PublishingHouse { get; private set; }
        public int ManufactureYear { get; private set; }

        public Book(string name, string authorSecondName, string publishingHouse, int manufactureYear) 
            : base(name, authorSecondName)
        {
            PublishingHouse = publishingHouse;
            ManufactureYear = manufactureYear;
        }

        // конструктор для создания из текста
        public Book(string[] args) : base(args) { }

        public override void ShowInfo()
        {
            Console.WriteLine($"Информация о книге:" +
                $"\n  Название: {Name}" +
                $"\n  Фамилия автора: {AuthorSecondName}" +
                $"\n  Издатель: {PublishingHouse}" +
                $"\n  Год издания: {ManufactureYear}");
        }

        public override void ReadFromText(string[] args)
        {
            Name = args[1];
            AuthorSecondName = args[2];
            PublishingHouse = args[3];
            ManufactureYear = Convert.ToInt32(args[4]);
        }
    }
}
