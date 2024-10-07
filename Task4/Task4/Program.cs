using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            var x = double.Parse(Console.ReadLine());

            var y = MyFunction(x);

            Console.WriteLine("f(x) = " + y);

            Console.ReadKey();
        }

        static double MyFunction(double x)
        {
            return Math.Sqrt((2 * x + Math.Sin(Math.Abs(3 * x))) / 3.56);
        }
    }
}
