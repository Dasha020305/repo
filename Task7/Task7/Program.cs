﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = GetNumber("n");

            if (IsStatementTrue(n))
                Console.WriteLine("Утверждение истинно");
            else
                Console.WriteLine("Утверждение ложно");

            Console.ReadKey();
        }

        static bool IsStatementTrue (int n)
        {
            return n % 5 == 0 && n % 7 != 0;
        }
        static int GetNumber (string numberName)
        {
            Console.WriteLine($"Введите число {numberName}");
            return int.Parse(Console.ReadLine());
        }
    }
}
