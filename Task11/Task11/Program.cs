using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число b:");
            int b;

            if (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Ошибка ввода. Необходимо ввести натуральное число.");
                Console.ReadKey();
                return;
            }
    
            var numbers = new int[15];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = CalculatePowerOfTwo(i) - b;
            }

            PrintArray(numbers);

            ChangeSignAtOddIndices(numbers);
            Console.WriteLine("Массив после изменения знака элементов с нечетными индексами:");
            PrintArray(numbers);

            double average = CalculateAverage(numbers);

            Console.WriteLine($"Среднее арифметическое: {average:F3}");

            Console.WriteLine("Введите целое число k:");
            int k;

            if (!int.TryParse(Console.ReadLine(), out k) || k == 0)
            {
                Console.WriteLine("Ошибка ввода. Необходимо ввести ненулевое целое число.");
                Console.ReadKey();
                return;
            }

            var remainders = GetRemainders(numbers, k);
            Console.WriteLine($"Остатки от деления элементов массива на {k}:");
            PrintArray(remainders);

            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join("; ", array));
        }

        static void ChangeSignAtOddIndices(int[] array)
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                array[i] = -array[i];
            }
        }

        static double CalculateAverage(int[] array)
        {
            if (array.Length == 0) return 0;

            double sum = 0;
            foreach (var element in array)
            {
                sum += element;
            }

            return sum / array.Length;
        }

        static int[] GetRemainders(int[] array, int k)
        {
            int[] remainders = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                remainders[i] = array[i] % k;
            }
            return remainders;
        }

        static int CalculatePowerOfTwo(int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= 2;
            }
            return result;
        }
    }
}