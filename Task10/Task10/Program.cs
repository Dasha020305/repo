using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число b");
            int b;

            if (!TryInputNumber(out b))
            {
                Console.ReadKey();
                return;
            }

            if (b == 0)
            {
                Console.WriteLine("Число не удовлетворяет условию b - целое число, неравное нулю ");
                Console.ReadKey();
                return;
            }

            var sumOfSquares = 0;

            for (int i = -b; i <= b * b; i++)
                sumOfSquares += i * i;

            Console.WriteLine($"Сумма квадратов всех целых чисел от {-b} до {b * b} равно {sumOfSquares}");

            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            number = n;
            return true;
        }
    }
}
