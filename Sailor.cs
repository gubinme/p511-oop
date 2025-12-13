using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Sailor : Human
    {
        public string Rank { get; set; }

        public Sailor(string name, int age, string rank) : base(name, age)
        {
            Rank = rank;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine($"Звание: {Rank}");
        }
    }

}
