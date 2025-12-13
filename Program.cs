using p511_oop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        static void Main()
        {
            Human human = new Human("Иван", 30);
            Builder builder = new Builder("Петр", 35, "Маляр");
            Sailor sailor = new Sailor("Андрей", 28, "Капитан");
            Pilot pilot = new Pilot("Михаил", 40, "ABC123");

            human.ShowInfo();
            builder.ShowInfo();
            sailor.ShowInfo();
            pilot.ShowInfo();
        }
    }

}
