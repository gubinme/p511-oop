using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Airplane
    {
        private string _name;
        private string _manufacturer;
        private int _year;
        private string _type;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Manufacturer
        {
            get => _manufacturer;
            set => _manufacturer = value;
        }

        public int Year
        {
            get => _year;
            set => _year = value;
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }

        public Airplane() { }

        public Airplane(string name, string manufacturer, int year, string type)
        {
            _name = name;
            _manufacturer = manufacturer;
            _year = year;
            _type = type;
        }

        public void ReadFromConsole()
        {
            Console.Write("Название самолёта: ");
            Name = Console.ReadLine();

            Console.Write("Производитель: ");
            Manufacturer = Console.ReadLine();

            Console.Write("Год выпуска: ");
            Year = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Тип самолёта: ");
            Type = Console.ReadLine();
        }

        public void PrintToConsole()
        {
            Console.WriteLine("Самолёт:");
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Производитель: {Manufacturer}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Тип: {Type}");
        }
    }
}
