using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите натуральное число n:");

            if (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.WriteLine("Ошибка ввода. Введите натуральное число больше 0.");
                Console.ReadKey();
                return;
            }

            int maxDigit = -1; 
            int position = 0; 
            int maxPosition = -1; 

            int temp = n;
            int divisor = 1;

            while (temp >= 10)
            {
                temp /= 10;
                divisor *= 10;
            }

            while (divisor > 0)
            {
                int digit = n / divisor;
                n %= divisor;
                divisor /= 10;

                if (digit > maxDigit)
                {
                    maxDigit = digit;
                    maxPosition = position; 
                }

                position++; 
            }

            if (maxPosition != -1)
            {
                Console.WriteLine($"Порядковый номер первой наибольшей цифры: {maxPosition}");
            }

            Console.ReadKey();
        }
    }
}