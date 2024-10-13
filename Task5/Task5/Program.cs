using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y = F(2, F(3, F(4, Math.Sqrt(5))));
            Console.WriteLine("x = " + Math.Round(y, 3));

            Console.ReadKey();
        }

        static double F(double a, double b)
        {
            return Math.Sqrt(a + b);
        }
    }
}
