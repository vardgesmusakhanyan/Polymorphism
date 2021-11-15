using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Polymorphism.Shape;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle();
            circle.Radius = radius;
            Console.WriteLine("Area :" + circle.Area());


            double length = Convert.ToDouble(Console.ReadLine());
            Square square = new Square();
            square.Length = length;
            Console.WriteLine("Area :" + square.Area());

            double height = Convert.ToDouble(Console.ReadLine());
            double width = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle();
            rectangle.Height = height;
            rectangle.Width = width;
            Console.WriteLine("Area :" + rectangle.Area());



            Shape circleShape = new Circle(radius);
            Console.WriteLine("Area :" + circleShape.Area());

            Shape squareShape = new Square(length);
            Console.WriteLine("Area :" + squareShape.Area());

            Shape rectangleShape = new Rectangle(height, width);
            Console.WriteLine("Area :" + rectangleShape.Area());

        }
    }
}
