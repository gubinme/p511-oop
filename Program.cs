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
            Student student = new Student
            {
                FullName = "Иванов Иван Иванович",
                BirthDate = "15.03.2002",
                PhoneNumber = "+7(800)555-35-35",
                City = "Тюмень",
                Country = "Россия",
                Institution = "МГУ имени М.В. Ломоносова",
                InstitutionCity = "Москва",
                InstitutionCountry = "Россия",
                GroupNumber = "ИТ-21"
            };

            student.DisplayData();

            Console.ReadKey();
        }
    }
}
