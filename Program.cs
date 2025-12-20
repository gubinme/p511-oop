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
            int[,] arr = new int[5, 5];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(-100, 101);
                }
            }

            int min = arr[0, 0], max = arr[0, 0];
            int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minRow = i;
                        minCol = j;
                    }
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            int sum = 0;
            for (int i = Math.Min(minRow, maxRow); i <= Math.Max(minRow, maxRow); i++)
            {
                for (int j = Math.Min(minCol, maxCol); j <= Math.Max(minCol, maxCol); j++)
                {
                    sum += arr[i, j];
                }
            }

            Console.WriteLine($"Сумма между min и max: {sum}");
        }
    }
}
