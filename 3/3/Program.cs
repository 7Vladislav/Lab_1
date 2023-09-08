using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Двумерный массив
            int[,] array2DInitialization = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    System.Console.Write(array2DInitialization[i, j] + " ");
                }
                System.Console.WriteLine();
            }

            // Массив строк
            string[] stringArray = { "red", "yellow", "blue", "purple", "white" };

            Console.WriteLine("Содержимое массива:");
            foreach (string element in stringArray)
            {
                Console.WriteLine(element);
            }

            int arrayLength = stringArray.Length;
            Console.WriteLine($"Длина массива: {arrayLength}");

            Console.Write("Введите позицию элемента для изменения (1 - 5): ");
            int position = int.Parse(Console.ReadLine()) - 1;

            if (position >= 0 && position < (arrayLength))
            {
                Console.Write("Введите новое значение для элемента: ");
                string newValue = Console.ReadLine();

                stringArray[position] = newValue;

                Console.WriteLine("Обновленное содержимое массива:");
                foreach (string element in stringArray)
                {
                    Console.WriteLine(element);
                }
            }
            else
            {
                Console.WriteLine("Недопустимая позиция.");
            }

            //Ступенчатые массивы
            // Создаем ступенчатый массив
            int[][] jaggedArray = new int[3][];

            // Определяем количество столбцов в каждой строке
            for (int i = 0, j =2; i <= 3 && j <= 4; i++, j++)
            {
            jaggedArray[i] = new int[j];
            }

            // Вводим значения с консоли
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"Введите значение для элемента [{i}][{j}]: ");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Выводим массив
            Console.WriteLine("Содержимое ступечатого массива:");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Неявно типизированные переменные для хранения строк и массивов
            var Array1 = new[] { 1, 2, 3, 4, 5 };
            var String1 = "Простая строка";

            Console.WriteLine("Неявно типизированная переменная, содержащая массив:");
            foreach (var element in Array1)
            {
                Console.WriteLine(element + " ");
            }

            Console.WriteLine("Неявно типизированная переменная, содержащая строку:");
            Console.WriteLine(String1);
        }

    }
}
