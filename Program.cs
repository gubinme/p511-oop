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
            Console.WriteLine("--- Рендеринг документов ---");
            Console.WriteLine("Начинаю рендеринг...");
            Console.WriteLine("--------------------");

            List<Document> documents = new List<Document>
            {
                new TextDocument
                {
                    Author = "Лев Толстой",
                    Content = "Все счастливые семьи похожи друг на друга..."
                },
                new ImageDocument
                {
                    Author = "Иван Шишкин",
                    Resolution = "3558x2180"
                },
                new TextDocument
                {
                    Author = "Михаил Булгаков",
                    Content = "В белом плаще с кровавым подбоем..."
                }
            };

            foreach (Document doc in documents)
            {
                doc.Render();
            }
        }
    }
}
