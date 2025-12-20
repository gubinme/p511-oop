using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public abstract class Document
    {
        public string Author { get; set; }

        public abstract void Render();
    }
}
