using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Pilot : Human
    {
        public string LicenseNumber { get; set; }

        public Pilot(string name, int age, string licenseNumber) : base(name, age)
        {
            LicenseNumber = licenseNumber;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine($"Номер лицензии: {LicenseNumber}");
        }
    }

}
