using System;

namespace labs
{
    internal class Rectangle
    {
        // приватные поля а и b
        private float _a, _b;

        // свойства для получения и изменения приватных переменных
        public float A { get => _a; set => _a = value; }
        public float B { get => _b; set => _b = value; }
        // свойство, вычисляющее является ли данный прямоугольник квадратом 
        public bool IsSquare { get => _a == _b; }

        // индексатор для изменения и получения а и b через индексы 0 и 1 соответственно
        public float this[int i]
        {
            get
            {
                if (i == 0) return _a;
                if (i == 1) return _b;
                throw new ArgumentException();
            }
            set
            {
                if (i == 0) _a = value;
                else if (i == 1) _b = value;
                else throw new ArgumentException();
            }
        }

        // конструктор
        public Rectangle(int a, int b)
        {
            this._a = a; 
            this._b = b;
        }

        // метод для вывода информации о прямоугольнике
        public void ShowSides() => Console.WriteLine($"Строна a:{_a}\nСтрона b:{_b}");
        // методы для вычисления периметра и площади
        public float GetPerimetr() => (_a + _b) * 2;
        public float GetSquare() => _a * _b;

        // определение что будет дулать оператор ++ для экземпляра данного класса
        public static Rectangle operator ++(Rectangle rectangle)
        {
            rectangle.A++;
            rectangle.B++;
            return rectangle;
        }

        // определение что будет дулать оператор -- для экземпляра данного класса
        public static Rectangle operator --(Rectangle rectangle)
        {
            rectangle.A--;
            rectangle.B--;
            return rectangle;
        }

        // определение что будет дулать оператор * для экземпляра данного класса
        public static Rectangle operator *(Rectangle rectangle, int scalar)
        {
            rectangle.A *= scalar;
            rectangle.B *= scalar;
            return rectangle;
        }

        // определение что будет дулать оператор true для экземпляра данного класса
        public static bool operator true(Rectangle rectangle) => rectangle.IsSquare;
        // определение что будет дулать оператор false для экземпляра данного класса
        public static bool operator false(Rectangle rectangle) => !rectangle.IsSquare;
    }
}
