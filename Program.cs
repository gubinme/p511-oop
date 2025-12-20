using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowHeader();
            double num1 = GetNumber("Введите первое число: ");
            double num2 = GetNumber("Введите второе число: ");
            char operation = GetOperation();
            double result = Calculate(num1, num2, operation);
            ShowResult(num1, num2, operation, result);
        }

        static void ShowHeader()
        {
            Console.WriteLine("--- Улучшенный калькулятор ---");
            Console.WriteLine("Доступные операции: +, -, *, /");
        }

        static double GetNumber(string prompt)
        {
            Console.Write(prompt);
            return double.Parse(Console.ReadLine());
        }

        static char GetOperation()
        {
            Console.Write("Введите символ операции: ");
            return Console.ReadLine()[0];
        }

        static double Calculate(double a, double b, char op)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return b != 0 ? a / b : double.NaN;
                default:
                    Console.WriteLine("Ошибка: неизвестная операция!");
                    return double.NaN;
            }
        }

        static void ShowResult(double a, double b, char op, double result)
        {
            if (double.IsNaN(result))
            {
                Console.WriteLine("Ошибка: невозможно выполнить операцию.");
            }
            else
            {
                Console.WriteLine($"Результат: {a} {op} {b} = {result}");
            }
        }
    }
}
