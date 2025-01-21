using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.EXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Самопорождёнными числами меньше 1000 являются:");

            for (int i = 1; i < 1000; i++)
            {
                if (IsSelfGeneratedNumber(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }

        static bool IsSelfGeneratedNumber(int number)
        {
            for (int i = 1; i < number; i++)
            {
                if (i + SumOfDigits(i) == number)
                {
                    return false;
                }
            }
            return true;
        }

        static int SumOfDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }
}
