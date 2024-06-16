using System;

namespace AbstractClassDemo
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape myCircle = new Circle(5);
            Shape myRectangle = new Rectangle(4, 6);

            Console.WriteLine($"Area of Circle: {myCircle.GetArea()}");
            Console.WriteLine($"Area of Rectangle: {myRectangle.GetArea()}");
        }
    }
}
