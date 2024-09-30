using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double a = double.Parse(Console.ReadLine());

            double v = (a*a*a);
            double d = (a * Math.Sqrt(3));

            Console.WriteLine("Объем куба: " + Math.Round(v, 3));
            Console.WriteLine("Длина диагонали: " + Math.Round(d, 3));
           

            Console.ReadKey();

        }
    }
}
