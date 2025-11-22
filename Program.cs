using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    // 1. сумма чисел от 1 до N
    // напишите программу, которая принимает целое число N и вычисляет сумму всех чисел от 1 до N включительно с помощью цикла (for)
    internal class Program
    {
        static int Sum(int n)
        {
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                a += i;
            }
            return a;
        }

        static void Main(string[] args)
        {
            int n = 10; // любое число
            Console.WriteLine(Sum(n));
        }
    }
}
