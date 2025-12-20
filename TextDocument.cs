using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class TextDocument : Document
    {
        public string Content { get; set; }

        public override void Render()
        {
            Console.WriteLine($"[Текст] Автор: {Author}");
            Console.WriteLine($"Содержимое: {Content}");
            Console.WriteLine("--------------------");
        }
    }
}
