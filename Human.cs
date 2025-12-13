using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void ShowInfo()
        {
            System.Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
        }
    }
}
