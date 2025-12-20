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
            Console.Write("¬ведите выражение (+ и -): ");
            string expr = Console.ReadLine();
            Console.WriteLine("–езультат: " + Calculate(expr));
        }

        static int Calculate(string expr)
        {
            int result = 0;
            int current = 0;
            bool isPositive = true;

            foreach (char c in expr)
            {
                if (char.IsDigit(c))
                {
                    current = current * 10 + (c - '0');
                }
                else if (c == '+')
                {
                    result += isPositive ? current : -current;
                    current = 0;
                    isPositive = true;
                }
                else if (c == '-')
                {
                    result += isPositive ? current : -current;
                    current = 0;
                    isPositive = false;
                }
            }
            result += isPositive ? current : -current;
            return result;
        }
    }
}
