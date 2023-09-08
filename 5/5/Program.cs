using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 52, 47, 14, 25, 30 };
            string String = "Простая строка";

            // Локальная функция
            (int max, int min, int sum, char firstLetter) localFunction(int[] array, string str)
            {
                int max = array[0];
                int min = array[0];
                int sum = 0;

                foreach (int num in array)
                {
                    if (num > max)
                    {
                        max = num;
                    }

                    if (num < min)
                    {
                        min = num;
                    }

                    sum += num;
                }

                char firstChar = str[0];

                return (max, min, sum, firstChar);
            }

            // Вызов локальной функции
            var result = localFunction(numbers, String);

            Console.WriteLine($"Максимальный элемент: {result.max}");
            Console.WriteLine($"Минимальный элемент: {result.min}");
            Console.WriteLine($"Сумма элементов: {result.sum}");
            Console.WriteLine($"Первая буква строки: {result.firstLetter}");
        }
    }
}
