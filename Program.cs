using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    class Program
    {
        static void Main()
        {
            // Одномерный массив A
            double[] A = new double[5];
            Console.WriteLine("Введите 5 чисел для массива A:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = double.Parse(Console.ReadLine());
            }

            // Двумерный массив B
            double[,] B = new double[3, 4];
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rand.NextDouble() * 100;
                }
            }

            // Вывод массивов
            Console.WriteLine("Массив A: " + string.Join(" ", A));
            Console.WriteLine("Массив B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{B[i, j]:F2} ");
                }
                Console.WriteLine();
            }

            // Общие вычисления
            double max = double.MinValue, min = double.MaxValue, sum = 0, product = 1;
            int sumEvenA = 0;
            int sumOddColsB = 0;

            foreach (double x in A)
            {
                max = Math.Max(max, x);
                min = Math.Min(min, x);
                sum += x;
                product *= x;
                if (x % 2 == 0) sumEvenA += (int)x;
            }

            for (int j = 0; j < 4; j++)
            {
                if (j % 2 == 1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        sumOddColsB += (int)B[i, j];
                    }
                }
            }

            Console.WriteLine($"Максимум: {max}, Минимум: {min}");
            Console.WriteLine($"Сумма: {sum}, Произведение: {product}");
            Console.WriteLine($"Сумма чётных A: {sumEvenA}, Сумма нечётных столбцов B: {sumOddColsB}");
        }
    }
}
