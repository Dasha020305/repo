using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;

            Console.WriteLine("Введите вещественное число a (a > 1):");
            if (!TryInputDouble(out a) || a <= 1)
            {
                Console.WriteLine("Ошибка ввода. Убедитесь, что a > 1.");
                Console.ReadKey();
                return;
            }

            double sum = 0;
            int n = 0;

            while (sum <= a)
            {
                n++;
                sum += 1 / Math.Sqrt(n);
            }

            Console.WriteLine($"Наименьшее натуральное число n, такое что сумма больше {a}: n = {n}");
            Console.ReadKey();
        }

        static bool TryInputDouble(out double number)
        {
            number = 0;
            return double.TryParse(Console.ReadLine(), out number);
        }
    }
}