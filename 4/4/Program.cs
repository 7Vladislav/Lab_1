using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int, string, char, string, ulong) myTuple = (123, "Первая строка", 'N', "Вторая строка", 1234567890UL);

            // Выводим кортеж целиком
            Console.WriteLine("Кортеж целиком:");
            Console.WriteLine(myTuple);

            // Выводим выборочные элементы кортежа
            Console.WriteLine("\nВыборочные элементы кортежа:");
            Console.WriteLine($"Первый элемент: {myTuple.Item1}");
            Console.WriteLine($"Третий элемент: {myTuple.Item3}");
            Console.WriteLine($"Четвертый элемент: {myTuple.Item4}");

            //Распаковка кортежа в переменные
            // Создаем кортеж из 5 элементов
            (int age, string name, char initial, string city, ulong number) person = (18, "Vlad", 'K', "Minsk", 8000000);

            // Распаковка с использованием именованных переменных
            int age1 = person.age;
            string name1 = person.name;
            char initial1 = person.initial;
            string city1 = person.city;
            ulong number1 = person.number;

            // Распаковка с использованием позиционных переменных
            var (age2, name2, initial2, city2, number2) = person;

            // символ "_" для игнорирования значений
            var (_, name3, _, _, _) = person;

            // Вывод значений переменных
            Console.WriteLine($"Имя: {name1}, Возраст: {age1}, Город: {city1}");
            Console.WriteLine($"Имя: {name2}, Возраст: {age2}, Город: {city2}");
            Console.WriteLine($"Имя: {name3}");

            //Сравнение кортежей

            if (myTuple == person)
            {
                Console.WriteLine("Кортежи равны.");
            }
            else
            {
                Console.WriteLine("Кортежи не равны.");
            }
        }
    }
}
