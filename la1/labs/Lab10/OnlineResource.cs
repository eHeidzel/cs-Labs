using System;

namespace labs
{
    internal class OnlineResource : Edition
    {
        public string Href { get; private set; }
        public string Annotation { get; private set; }

        public OnlineResource(string name, string authorSecondName, string href, string annotation) 
            : base(name, authorSecondName)
        {
            Href = href;
            Annotation = annotation;
        }

        // конструктор для создания из текста
        public OnlineResource(string[] args) : base(args) { }

        public override void ShowInfo()
        {
            Console.WriteLine($"Информация о онлайн ресурсе:" +
                $"\n  азвание: {Name}" +
                $"\n  Фамилия автора: {AuthorSecondName}" +
                $"\n  Аннотация: {Annotation}" +
                $"\n  Гиперссылка: {Href}");
        }

        public override void ReadFromText(string[] args)
        {
            Name = args[1];
            AuthorSecondName = args[2];
            Annotation = args[3];
            Href = args[4];
        }
    }
}
