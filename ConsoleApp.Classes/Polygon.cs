using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    public abstract class Polygon
    {
        public int Width { get; set; }

        public abstract int Area();
    }
}
