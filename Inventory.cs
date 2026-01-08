using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Inventory
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Добавлен товар: {product}");
        }

        public Product FindProduct(int id)
        {
            return products.Find(p => p.Id == id);
        }
    }
}
