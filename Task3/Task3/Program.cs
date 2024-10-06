using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время, на которое указывает часовая стрелка (1-12):");
            double hour = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите время, на которое указывает минутная стрелка (0-59):");
            double minute = double.Parse(Console.ReadLine());

            double hourAngle = (hour * 60 + minute) * 0.5;
            double minuteAngle = minute * 6;
            double angleDifference = Math.Abs(hourAngle - minuteAngle);
            double minuteSpeed = 6;
            double hourSpeed = 0.5;
            double relativeSpeed = minuteSpeed - hourSpeed;
            double minutesUntilOverlap = angleDifference / relativeSpeed;

            Console.WriteLine("Часовая и минутная стрелки совпадут через " + Math.Round(minutesUntilOverlap,2) + " минут.");



            Console.ReadKey();
        }
    }
}

