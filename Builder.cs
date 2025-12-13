using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Builder : Human
    {
        public string Specialty { get; set; }

        public Builder(string name, int age, string specialty) : base(name, age)
        {
            Specialty = specialty;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine($"Специальность: {Specialty}");
        }
    }

}
