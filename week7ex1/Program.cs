using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a program that defines a shape class with a constructor that gives value to width and height. 
Then define two sub-classes, triangle and rectangle, that calculate the area of the shape area. 
Test the two sub-classes by defining two variables, a triangle and a rectangle, and then call the area function for these two variables. 
  */
namespace week7ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle(10, 2);
            Console.WriteLine(myRectangle.CalcArea());
            Triangle myTriangle = new Triangle(10, 2);
            Console.WriteLine(myTriangle.CalcArea());
            Console.ReadKey();
        }
    }
}
