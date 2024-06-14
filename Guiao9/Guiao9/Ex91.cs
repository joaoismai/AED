using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao9
{
    internal class Ex91
    {
        public class Shape
        {
            public virtual double Area() => 0;
            public virtual double Perimeter() => 0;

            public static double GetArea(Shape shape) => shape.Area();
            public static double GetPerimeter(Shape shape) => shape.Perimeter();
        }

        public class Rectangle : Shape
        {
            public double width, height;

            public Rectangle(double width, double height)
            {
                if (width <= 0 || height <= 0)
                    throw new ArgumentException("The width and the height of a Rectangle should be > 0.");
                this.width = width;
                this.height = height;
            }

            public override double Area() => width * height;
            public override double Perimeter() => 2 * (width + height);

            public bool IsSquare() => width == height;
            public double Diagonal => Math.Sqrt(width * width + height * height);

            public override string ToString() => $"Rectangle (Width: {width}, Height: {height})";
        }

        public class Square : Rectangle
        {
            public Square(double side) : base(side, side) { }

            public override string ToString()
            {
                return $"Square (Side: {width})";
            }
        }

        public class Circle : Shape
        {
            private double radius;

            public Circle(double radius)
            {
                if (radius <= 0)
                    throw new ArgumentException("The radius of a Circle should be > 0.");
                this.radius = radius;
            }

            public override double Area() => Math.PI * radius * radius;
            public override double Perimeter() => 2 * Math.PI * radius;

            public double Diameter => 2 * radius;

            public override string ToString() => $"Circle (Radius: {radius})";
        }
    }
}
