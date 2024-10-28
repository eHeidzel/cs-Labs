using System;

namespace labs
{
    internal class Lab05
    {
        public static Random rand = new Random();
        public static int[] nums;

        //ввод длины массива и заполнение случайными значениями
        private static void ReadRandArray()
        {
            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            nums = new int[n];

            for (int i = 0; i < nums.Length; i++)
                nums[i] = rand.Next(-10, 11);

            Console.WriteLine();
        }

        //вывести массив на экран
        public static void PrintRandArray(int deleted=0)
        {
            for (int i = 0; i < nums.Length - deleted; i++)
            {
                Console.Write($"{nums[i]} ");
            } 
            Console.WriteLine();
        }

        public static void Task1()
        {
            ReadRandArray();
            Console.WriteLine("Исходный массив");
            PrintRandArray();

            // если элемент меньше 0, то умножаем его на 2
            for (int i = 0; i < nums.Length; i++)
                nums[i] = nums[i] < 0 ? nums[i] * 2 : nums[i];

            Console.WriteLine("Итоговый массив");
            PrintRandArray();
        }

        public static void Task2()
        {
            ReadRandArray();
            Console.WriteLine("Исходный массив");
            PrintRandArray();

            int deleted = 0;
            int minEven = int.MaxValue;
            int maxOdd = int.MinValue;
            
            for (int i = 0; i < nums.Length; i++)
            {
                //поиск максимального нечётного
                if (nums[i] > 0 && nums[i] % 2 == 1)
                    if (nums[i] > maxOdd)
                        maxOdd = nums[i];

                //поиск минимального чётного
                if (nums[i] > 0 && nums[i] % 2 == 0)
                    if (nums[i] < minEven)
                        minEven = nums[i];

                //если число совершенное, то на его место присваивается минимально возможное значение
                if (IsPerfect(nums[i]))
                {
                    deleted++;
                    nums[i] = int.MinValue;
                }
            }

            //"удаление" всех совершенных элементов путём сдвига
            for (int i = 0; i < deleted; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == int.MinValue)
                        for (int k = j; k < nums.Length; k++)
                        {
                            if (k == nums.Length - 1)
                                nums[k] = 0;
                            else
                                nums[k] = nums[k + 1];
                        }
                }
            }

            //вывод информации
            string errorMessage = "Не найдено";
            string fm = maxOdd != int.MinValue ? maxOdd.ToString() : errorMessage;
            string sm = minEven != int.MaxValue ? minEven.ToString() : "Не найдено";

            Console.WriteLine($"Максимальное положительное нечётное {fm}");
            Console.WriteLine($"Минимальное положительное чётное {sm}");
            Console.WriteLine($"Всего удалено {deleted}");

            Console.WriteLine("Итоговый массив");
            PrintRandArray(deleted);
        }

        //алгоритм вычисления совершенности числа
        public static bool IsPerfect(int num)
        {
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    sum += i;
            }

            return sum == num * 2 ? true : false;
        }

        public static void Task3()
        {
            Console.WriteLine("Введите размер квадратной матрицы");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, n];

            //заполнение матрицы
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(0, 5);
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }

            int sum = 0;

            //вычисление суммы по периметру
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n-1)
                {
                    for (int j = 0; j < n; j++)
                        sum += matrix[i, j];

                    continue;
                }

                sum += matrix[i, 0] + matrix[i, n - 1];
            }

            Console.WriteLine($"Сумма по периметру равна {sum}");
        }
    }
}
