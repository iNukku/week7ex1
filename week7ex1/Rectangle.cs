using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7ex1
{
    public class Rectangle : Shape
    {
        public Rectangle(double length, double width) : base(length, width)
        {
            this.length = length;
            this.width = width;
        }
    }
}
