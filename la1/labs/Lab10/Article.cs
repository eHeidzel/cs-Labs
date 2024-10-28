using System;

namespace labs
{
    internal class Article : Edition
    {
        public string JournalName { get; private set; }
        public int JournalNumber { get; private set; }
        public int JournalManufactureYear { get; private set; }

        public Article(
            string name, string authorSecondName,
            string journalName, int journalNumber,
            int journalManufactureYear) : base(name, authorSecondName)
        {
            JournalName = journalName;
            JournalNumber = journalNumber;
            JournalManufactureYear = journalManufactureYear;
        }

        // конструктор для создания из текста
        public Article(string[] args) : base(args) { }

        public override void ShowInfo()
        {
            Console.WriteLine($"Информация о книге:" +
                $"\n  Название: {Name}" +
                $"\n  Фамилия автора: {AuthorSecondName}" +
                $"\n  Издатель: {JournalName}" +
                $"\n  Год издания: {JournalManufactureYear}" +
                $"\n  Номер журнала: {JournalNumber}");
        }

        public override void ReadFromText(string[] args)
        {
            Name = args[1];
            AuthorSecondName = args[2];
            JournalName = args[3];
            JournalManufactureYear = Convert.ToInt32(args[4]);
            JournalNumber = Convert.ToInt32(args[5]);
        }
    }
}
