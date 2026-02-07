using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class ImageDocument : Document
    {
        public string Resolution { get; set; }

        public override void Render()
        {
            Console.WriteLine($"[Изображение] Автор: {Author}");
            Console.WriteLine($"Рендеринг изображения с разрешением {Resolution}");
            Console.WriteLine("--------------------");
        }
    }
}
