using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сравнение строковых литералов
            string strA = "Hello, World!";
            string strB = "hello, world!";

            bool areEqual = strA.Equals(strB, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine($"Сравнение без учета регистра: {areEqual}");

            //Действия над string
            // Создаем три строки
            string str1 = "Работа";
            string str2 = " со строками";
            string str3 = "на языке C#";

            // 1. Сцепление строк
            string concatenatedString = str1 + str2;
            Console.WriteLine("Сцепление строк: " + concatenatedString);

            // 2. Копирование строки
            string copiedString = String.Copy(str3);
            Console.WriteLine("Копированная строка: " + copiedString);

            // 3. Выделение подстроки
            string substring = str3.Substring(3, 4);
            Console.WriteLine("Подстрока: " + substring);

            // 4. Разделение строки на слова
            string sentence = "Это простое предложение.";
            string[] words = sentence.Split(' ');
            Console.WriteLine("Разделение строки на слова:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // 5. Вставка подстроки в заданную позицию
            string originalString = "ещё одно простое предложение";
            string insertedSubstring = "просто ";
            int position = 0;
            string resultString = originalString.Insert(position, insertedSubstring);
            Console.WriteLine("Вставка подстроки: " + resultString);

            // 6. Удаление заданной подстроки
            string stringWithoutSubstring = resultString.Remove(position, insertedSubstring.Length);
            Console.WriteLine("Удаление подстроки: " + stringWithoutSubstring);

            // 7. Интерполирование строк
            string month = "Сентябрь";
            int day = 8;
            string interpolatedString = $"Сегодня {month} {day}.";
            Console.WriteLine("Интерполированная строка: " + interpolatedString);

            //Пустая и null строки
            string emptyString = "";
            string nullString = null;

            bool isEmpty = string.IsNullOrEmpty(emptyString);
            bool isNull = string.IsNullOrEmpty(nullString);

            Console.WriteLine("Пустая строка: " + (isEmpty ? "пуста" : "не пуста"));
            Console.WriteLine("Null строка: " + (isNull ? "пуста" : "не пуста"));


            emptyString += "Добавленный текст";
            Console.WriteLine("Пустая строка с добавленным текстом: " + emptyString);

            nullString += "Добавленный текст";
            Console.WriteLine("Null строка с добавленным текстом: " + nullString);

            // Работа с StringBuilder
            StringBuilder stringBuilder = new StringBuilder("Простая строка", 30);

            stringBuilder.Remove(5, 2);
            stringBuilder.Insert(0, "Начало ");
            stringBuilder.Append(" Конец.");

            Console.WriteLine("Итоговая строка: " + stringBuilder);
        }
    }
}
