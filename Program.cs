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
            Console.WriteLine("--- Создание профилей студентов ---");

            Student student1 = new Student("Иван", "Петров", 19);
            Console.WriteLine($"Студент 1:");
            Console.WriteLine($"Привет, меня зовут {student1.FullName}, мне {student1.Age} лет.");
            Console.WriteLine($"Полное имя: {student1.FullName}");

            Student student2 = new Student("Анна", "Сидорова", 20);
            Console.WriteLine($"Студент 2:");
            Console.WriteLine($"Привет, меня зовут {student2.FullName}, мне {student2.Age} лет.");
            Console.WriteLine($"Полное имя: {student2.FullName}");

            Console.WriteLine("--- Попытка изменить возраст на некорректное значение ---");
            student1.Age = -5; // попытка установить некорректный возраст
            Console.WriteLine($"Текущий возраст студента 1: {student1.Age}");
        }
    }
}
