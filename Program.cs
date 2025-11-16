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
        }
    }
}

