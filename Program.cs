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
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Console.Write("Введите недопустимое слово: ");
            string badWord = Console.ReadLine();

            int count = 0;
            string result = ReplaceBadWords(text, badWord, ref count);

            Console.WriteLine("Результат: " + result);
            Console.WriteLine($"Статистика: {count} замены слова {badWord}.");
        }

        static string ReplaceBadWords(string text, string badWord, ref int count)
        {
            string replacement = new string('*', badWord.Length);
            string result = text.Replace(badWord, replacement);
            count = (text.Length - result.Length) / badWord.Length;
            return result;
        }
    }
}
