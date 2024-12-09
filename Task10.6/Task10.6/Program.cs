using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            if (!TryInputNumber("Введите число a", out a))
            {
                Console.ReadKey();
                return;
            }

            int b = 0;
            if (!TryInputNumber("Введите число b", out b))
            {
                Console.ReadKey();
                return;
            }

            if (a >= b)
            {
                Console.WriteLine("Ошибка: a должно быть меньше b.");
                Console.ReadKey();
                return;
            }

            int k = 0;
            if (!TryInputNumber("Введите число k", out k))
            {
                Console.ReadKey();
                return;
            }

            if (k < 2)
            {
                Console.WriteLine("Ошибка: k должно быть не менее 2.");
                Console.ReadKey();
                return;
            }

            int counter = 0;

            for (int number = a; number <= b; number++)
            {
                int divisorCount = CountDivisors(number);
                if (divisorCount == k)
                {
                    Console.Write($"{number}, ");
                    counter++;
                }
            }

            if (counter == 0)
                Console.WriteLine($"Натуральных чисел в диапазоне [{a}, {b}] с количеством делителей {k} нет.");
            else
                Console.WriteLine("\b\b ");

            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            return true;
        }

        static int CountDivisors(int number)
        {
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }

            return count;
        }
    }
}
