using System;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел (n):");
            int n;

            if (!TryInputNumber(out n) || n <= 0)
            {
                Console.ReadKey();
                return;
            }

            double product = 1;
            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите число a{i + 1}:");
                double number;
                if (!TryInputDouble(out number))
                {
                    Console.ReadKey();
                    return;
                }

                numbers[i] = number;
                product *= number;
            }

            // Выводим модуль произведения сразу
            Console.WriteLine($"Результат произведения: {Math.Abs(product)}");

            Console.WriteLine("Произведение:");
            Console.WriteLine($"n = {n}");
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine($"k = {k + 1}, a{k + 1} = {numbers[k]}");
            }

            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода. Введите целое число.");
                return false;
            }

            number = n;
            return true;
        }

        static bool TryInputDouble(out double number)
        {
            number = 0;
            if (!double.TryParse(Console.ReadLine(), out double n))
            {
                Console.WriteLine("Ошибка ввода. Введите действительное число.");
                return false;
            }

            number = n;
            return true;
        }
    }
}
