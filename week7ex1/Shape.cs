using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7ex1
{
    public class Shape
    {
        protected double length;
        protected double width;

        public Shape(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public virtual double CalcArea()
        {
            return width * length;
        }
    }
}
