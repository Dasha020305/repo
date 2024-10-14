using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "трос";

            Console.WriteLine("Первое полученное слово:");
            Console.WriteLine(ReverseString(s));

            var word2 = s
                .Remove(0, 1);

            word2 += s.Substring(0, 1);

            Console.WriteLine("\nВторое полученное слово:");
            Console.WriteLine(word2);

            Console.ReadKey();
        }
        static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }
    }
}
