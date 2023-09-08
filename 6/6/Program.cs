using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вызываем локальные функции
            Console.WriteLine("Вызов функции с блоком checked:");
            FunctionWithChecked();

            Console.WriteLine("Вызов функции с блоком unchecked:");
            FunctionWithUnchecked();
        }

        static void FunctionWithChecked()
        {
            try
            {
                checked
                {
                    int maxValue = int.MaxValue;
                    Console.WriteLine($"Значение в блоке checked: {maxValue}");
                    maxValue++;
                    Console.WriteLine($"Увеличенное значение в блоке checked: {maxValue}");
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Произошло переполнение: {ex.Message}");
            }
        }

        static void FunctionWithUnchecked()
        {
            unchecked
            {
                int maxValue = int.MaxValue;
                Console.WriteLine($"Значение в блоке unchecked: {maxValue}");
                maxValue++;
                Console.WriteLine($"Увеличенное значение в блоке unchecked: {maxValue}");
            }
        
        }
    }
}
