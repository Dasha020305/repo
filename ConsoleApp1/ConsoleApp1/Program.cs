using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Она");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Две незабудки, два сапфира —\r\nЕе очей приветный взгляд,\r\nИ тайны горнего эфира\r\nВ живой лазури их сквозят.\r\nЕе кудрей руно златое\r\nВ таком свету, какой один,\r\nИзображая неземное,\r\nСводил на землю Перуджин.");

            Console.ReadKey();
        }
    }
}
