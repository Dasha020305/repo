﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргумента функции");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine($"f({x}) = {MyFunction(x)}");

            Console.ReadKey ();

        }
        static double MyFunction(double x)
        {
            if (x <= 0)
                return -3 * x;
            else if (x > 2)
                return 2;

            return 0;
        }
    }
}
