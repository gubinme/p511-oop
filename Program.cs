using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.firstName = "Джон";
            student1.lastName = "До";
            student1.age = 19;

            Student student2 = new Student();

            student2.firstName = "Том";
            student2.lastName = "До";
            student2.age = 20;

            Console.WriteLine(" Знакомство со студентами ");
            student1.Introduce();
            student2.Introduce();

            Console.ReadLine();
        }
    }

    public class Student
    {
        public string firstName;
        public string lastName;
        public int age;

        public void Introduce()
        {
            Console.WriteLine($"Привет, меня зовут {firstName} {lastName}, мне {age} лет");
            Console.WriteLine("создаем корректный прямоугольник:");
            Rectangle rect1 = new Rectangle(20, 30);
            Console.WriteLine($"ширина: {rect1.Width}");
            Console.WriteLine($"высота: {rect1.Height}");
            Console.WriteLine($"площадь: {rect1.GetArea()}");
            Console.WriteLine($"периметр: {rect1.GetPerimeter()}");
            Console.WriteLine("\nпопытка создать некорректный прямоугольник");
            Rectangle rect2 = new Rectangle(-10, 10);
            Console.WriteLine($"ширина rect2: {rect2.Width}");
            Console.WriteLine($"высота rect2: {rect2.Height}");
            Console.WriteLine("\nпопытка изменить свойство на некорректное значение");
            rect1.Width = -20;
            Console.WriteLine($"новая ширина rect1 после попытки изменения: {rect1.Width}");
            Console.ReadLine();
        }
    }
    public class Rectangle
    {
        private double _width;
        private double _height;

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    Console.WriteLine("Ошибка: ширина должна быть положительным числом!");
                }
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    Console.WriteLine("Ошибка: высота должна быть положительным числом!");
                }
            }
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return _width * _height;
        }

        public double GetPerimeter()
        {
            return 2 * (_width + _height);
        }
    }
}

