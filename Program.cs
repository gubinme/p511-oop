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
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            Console.Write("Введите сдвиг: ");
            int shift = int.Parse(Console.ReadLine());

            string encrypted = CaesarEncrypt(text, shift);
            string decrypted = CaesarDecrypt(encrypted, shift);

            Console.WriteLine($"Зашифровано: {encrypted}");
            Console.WriteLine($"Расшифровано: {decrypted}");
        }

        static string CaesarEncrypt(string text, int shift)
        {
            string result = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    result += (char)((c - baseChar + shift) % 26 + baseChar);
                }
                else result += c;
            }
            return result;
        }

        static string CaesarDecrypt(string text, int shift)
        {
            return CaesarEncrypt(text, 26 - shift);
        }
    }
}
