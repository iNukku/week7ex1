using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7ex1
{
    class Triangle : Shape
    {
        public Triangle(double length, double width) : base(length, width)
        {

        }

        public override double CalcArea()
        {
            double result = (this.length * this.width) / 2;
            return result;
        }
    }
}
