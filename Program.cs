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
            Console.WriteLine("Результат: " + CapitalizeSentences(text));
        }

        static string CapitalizeSentences(string text)
        {
            string[] sentences = text.Split('.');
            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Length > 0)
                {
                    sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
                }
            }
            return string.Join(".", sentences);
        }
    }
}
