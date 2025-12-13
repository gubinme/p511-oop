using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Employee
    {
        private string _fullName;
        private DateTime _birthDate;
        private string _phone;
        private string _workEmail;
        private string _position;
        private string _dutiesDescription;

        public string FullName
        {
            get => _fullName;
            set => _fullName = value;
        }

        public DateTime BirthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        public string WorkEmail
        {
            get => _workEmail;
            set => _workEmail = value;
        }

        public string Position
        {
            get => _position;
            set => _position = value;
        }

        public string DutiesDescription
        {
            get => _dutiesDescription;
            set => _dutiesDescription = value;
        }

        public void ReadFromConsole()
        {
            Console.Write("ФИО: ");
            FullName = Console.ReadLine();

            Console.Write("Дата рождения (гггг-мм-дд): ");
            BirthDate = DateTime.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Телефон: ");
            Phone = Console.ReadLine();

            Console.Write("Рабочий email: ");
            WorkEmail = Console.ReadLine();

            Console.Write("Должность: ");
            Position = Console.ReadLine();

            Console.Write("Описание обязанностей: ");
            DutiesDescription = Console.ReadLine();
        }

        public void PrintToConsole()
        {
            Console.WriteLine("Сотрудник:");
            Console.WriteLine($"ФИО: {FullName}");
            Console.WriteLine($"Дата рождения: {BirthDate:d}");
            Console.WriteLine($"Телефон: {Phone}");
            Console.WriteLine($"Рабочий email: {WorkEmail}");
            Console.WriteLine($"Должность: {Position}");
            Console.WriteLine($"Обязанности: {DutiesDescription}");
        }
    }
}
