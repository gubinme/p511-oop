using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Student
    {
        public string FullName { get; set; } = string.Empty;
        public string BirthDate { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Institution { get; set; } = string.Empty;
        public string InstitutionCity { get; set; } = string.Empty;
        public string InstitutionCountry { get; set; } = string.Empty;
        public string GroupNumber { get; set; } = string.Empty;

        public void DisplayData()
        {
            Console.WriteLine("Данные студента:");
            Console.WriteLine($"ФИО: {FullName}");
            Console.WriteLine($"Дата рождения: {BirthDate}");
            Console.WriteLine($"Телефон: {PhoneNumber}");
            Console.WriteLine($"Город проживания: {City}");
            Console.WriteLine($"Страна проживания: {Country}");
            Console.WriteLine($"Учебное заведение: {Institution}");
            Console.WriteLine($"Город учебного заведения: {InstitutionCity}");
            Console.WriteLine($"Страна учебного заведения: {InstitutionCountry}");
            Console.WriteLine($"Номер группы: {GroupNumber}");
        }
    }
}
