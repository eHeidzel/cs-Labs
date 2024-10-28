using System;

namespace labs
{
    public abstract class Edition : IComparable
    {
        public string Name { get; protected set; }
        public string AuthorSecondName { get; protected set; }

        protected Edition(string name, string authorSecondName) 
        {
            Name = name;
            AuthorSecondName = authorSecondName;
        }

        // конструктор для создания из текста
        public Edition(string[] args)
        {
            ReadFromText(args);
        }

        // абстрактные методы для переопределения в будущем
        public abstract void ShowInfo();
        public abstract void ReadFromText(string[] args);

        public bool IsDesired(string searchedAuthorFullname) => AuthorSecondName == searchedAuthorFullname;

        //метод, который будет использоваться для сортировки
        public int CompareTo(object obj)
        {
            Edition other = obj as Edition;

            if (other == null)
                throw new ArgumentException();

            return string.Compare(AuthorSecondName, other.AuthorSecondName);
        }
    }
}
