using System;

class Program
{
    static double F(double x, double a, double b, double c)
    {
        return x * x * x + a * x * x + b * x + c;
    }

    static bool IsRootFound(double left, double right, double epsilon, double a, double b, double c)
    {
        while (right - left > epsilon)
        {
            double middle = (left + right) / 2;
            if (F(middle, a, b, c) == 0)
            {
                return true;
            }
            else if (F(left, a, b, c) * F(middle, a, b, c) < 0)
            {
                right = middle;
            }
            else
            {
                left = middle;
            }
        }
        return false;
    }

    static void Main()
    {
        Console.WriteLine("Введите коэффициенты a, b, c:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите точность e:");
        double epsilon = Convert.ToDouble(Console.ReadLine());

        int n = 1;
        while (true)
        {
            if (F(-n, a, b, c) < 0)
            {
                break;
            }
            n++;
        }

        if (IsRootFound(-n, 0, epsilon, a, b, c))
        {
            Console.WriteLine("Корень найден.");
        }
        else
        {
            Console.WriteLine("Корень не найден.");
        }

        Console.ReadKey();
    }
}
