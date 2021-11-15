using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Shape
    {
        public virtual double Area()
        {
            return default;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Square : Shape
    {
        public double Length { get; set; }

        public Square()
        {

        }

        public Square(double length)
        {
            Length = length;
        }

        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }

    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(double height, double  width)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
