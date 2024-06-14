using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao8
{
    internal class Ex83
    {
        public class Circle
        {
            private double radius;

            public Circle(double radius)
            {
                if (radius <= 0)
                    throw new ArgumentException("The radius of a Circle should be > 0.");
                this.radius = radius;
            }

            public double Area() => Math.PI * radius * radius;
            public double Perimeter() => 2 * Math.PI * radius;

            public override string ToString() => $"Circle (Radius: {radius})";
            public override bool Equals(object obj) => obj is Circle other && radius == other.radius;
        }

        public class Triangle
        {
            private double a, b, c;

            public Triangle(double a, double b, double c)
            {
                if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
                    throw new ArgumentException("The sides of a Triangle must satisfy the triangular inequality.");
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public double Area()
            {
                double s = (a + b + c) / 2;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }

            public double Perimeter() => a + b + c;

            public override string ToString() => $"Triangle (Side A: {a}, Side B: {b}, Side C: {c})";
            public override bool Equals(object obj) => obj is Triangle other && a == other.a && b == other.b && c == other.c;
        }

        public class Rectangle
        {
            private double width, height;

            public Rectangle(double width, double height)
            {
                if (width <= 0 || height <= 0)
                    throw new ArgumentException("The width and the height of a Rectangle should be > 0.");
                this.width = width;
                this.height = height;
            }

            public double Area() => width * height;
            public double Perimeter() => 2 * (width + height);

            public override string ToString() => $"Rectangle (Width: {width}, Height: {height})";
            public override bool Equals(object obj) => obj is Rectangle other && width == other.width && height == other.height;
        }
    }
}
