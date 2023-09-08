using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //переменные всех типов
            sbyte sbyteVar = 57;
            Console.WriteLine("sbyteVar: " + sbyteVar);

            byte byteVar = 11;
            Console.WriteLine("byteVar: " + byteVar);

            short shortVar = -30;
            Console.WriteLine("shortVar: " + shortVar);

            ushort ushortVar = 67;
            Console.WriteLine("ushortVar: " + ushortVar);

            int intVar = -46;
            Console.WriteLine("intVar: " + intVar);

            uint uintVar = 60;
            Console.WriteLine("uintVar: " + uintVar);

            long longVar = -13;
            Console.WriteLine("longVar: " + longVar);

            ulong ulongVar = 62;
            Console.WriteLine("ulongVar: " + ulongVar);

            float floatVar = 7.93f;
            Console.WriteLine("floatVar: " + floatVar);

            double doubleVar = 2.58294;
            Console.WriteLine("doubleVar: " + doubleVar);

            decimal decimalVar = 581.112m;
            Console.WriteLine("decimalVar: " + decimalVar);

            bool boolVar = true;
            Console.WriteLine("boolVar: " + boolVar);

            char charVar = 'A';
            Console.WriteLine("charVar: " + charVar);

            string stringVar = "Строка";
            Console.WriteLine("stringVar: " + stringVar);

            //явное и неявное приведение, класс Convert

            //явные
            int int1 = 2;
            double doubleValue = (double)int1;

            long long1 = 39;
            int int2 = (int)long1;

            float float1 = 3.77f;
            int int3 = (int)float1;

            decimal decimal1 = 216.745m;
            int int4 = (int)decimal1;

            ushort ushort1 = 4256;
            byte byte1 = (byte)ushort1;

            //неявные
            int a = 23;
            double b = a;

            short c = 16;
            int d = c;

            float e = 6.29f;
            double f = e;

            long g = 52;
            decimal h = g;

            byte i = 8;
            float j = i;

            //Класс Convert
            int intV = Convert.ToInt32("10");
            bool boolV = Convert.ToBoolean("True");
            string stringV = Convert.ToString(123);

            //упаковка и распаковка значимых типов

            //упаковка
            int obj1 = 10;
            object obj2 = (object)obj1;

            double obj3 = 3.14;
            IConvertible obj4 = (IConvertible)obj3;

            //распаковка
            object obj5 = 10;
            int obj6 = (int)obj5;

            IConvertible obj7 = 1.11;
            double obj8 = (double)obj7;

            //Работа с неявно типизированной переменной 
            var firstName = "Владислав";
            var lastName = "Коноваленко";
            var age = 18;

            Console.WriteLine($"Имя: {firstName}, Фамилия: {lastName}, Возраст: {age}");

            //Работа с Nullable переменной
            int? nullableInt = null;

            // Проверка на null
            if (nullableInt.HasValue)
            {
                Console.WriteLine("Значение nullableInt: " + nullableInt.Value);
            }
            else
            {
                Console.WriteLine("nullableInt равно null");
            }
            //Определите переменную  типа  var и присвойте ей любое значение. Затем следующей инструкцией присвойте ей значение другого типа. Объясните причину ошибки.
            /*
             
              var x = 42;
              x = "Привет, мир!"; 
              Нельзя присвоить строку (string) переменной типа int

             */
        }
    }
}

