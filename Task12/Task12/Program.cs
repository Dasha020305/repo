using System;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число m от 5 до 20");
            int m;

            if (!TryInputNumber(out m))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите целое число n от 5 до 20");
            int n;

            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }

            if (m < 5 || m > 20 || n < 5 || n > 20)
            {
                Console.WriteLine("Числа не удовлетворяют неравенству ");
                Console.ReadKey();
                return;
            }

            var matrix = new int[m, n];

            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(100);

            PrintMatrix(matrix);
            Console.WriteLine();

            CheckRowsInAscendingOrder(matrix);
            Console.WriteLine();

            CalculateSumOfOddElementsInColumns(matrix);

            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            number = n;
            return true;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],2} ");

                Console.WriteLine();
            }
        }

        static void CheckRowsInAscendingOrder(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] > matrix[i, j + 1])
                    {
                        Console.WriteLine($"Нарушение порядка на строке {i}, столбец {j} и {j + 1}");
                        return;
                    }
                }
            }
            Console.WriteLine("Все строки упорядочены по возрастанию.");
        }

        static void CalculateSumOfOddElementsInColumns(int[,] matrix)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                int sum = 0;
                for (var i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        sum += matrix[i, j];
                    }
                }
                Console.WriteLine($"Столбец {j} - сумма нечетных элементов: {sum}");
            }
        }
    }
}
