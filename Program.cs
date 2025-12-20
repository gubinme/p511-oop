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
            Console.WriteLine("--- Управление инвентарем ---");

            Inventory inventory = new Inventory();

            inventory.AddProduct(new Product(1, "Молоко", 80.50m));
            inventory.AddProduct(new Product(2, "Хлеб", 40.00m));
            inventory.AddProduct(new Product(3, "Сыр", 450.99m));

            Console.WriteLine("--- Поиск товара с ID 2 ---");
            Product found = inventory.FindProduct(2);
            if (found != null)
            {
                Console.WriteLine($"Найден товар: {found}");
            }
            else
            {
                Console.WriteLine("Товар с ID 2 не найден.");
            }

            Console.WriteLine("--- Поиск товара с ID 99 ---");
            found = inventory.FindProduct(99);
            if (found != null)
            {
                Console.WriteLine($"Найден товар: {found}");
            }
            else
            {
                Console.WriteLine("Товар с ID 99 не найден.");
            }
        }
    }
}
