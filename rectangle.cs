using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Rectangle
    {
        public double width;
        public double height;

        public double GetArea()
        {
            return width * height;
        }

        public double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }
}
