namespace _05.CrossingFigures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Point2D
    {
        public Point2D(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }
    }

    public class Circle
    {
        public Circle(double centerX, double centerY, double radius)
        {
            this.Center = new Point2D(centerX, centerY);
            this.Radius = radius;
        }

        public Point2D Center { get; set; }

        public double Radius { get; set; }
    }

    public class Rectangle
    {
        public Rectangle(double aX, double aY, double bX, double bY)
        {
            this.A = new Point2D(aX, aY);
            this.B = new Point2D(bX, bY);
        }

        public Point2D A { get; set; }

        public Point2D B { get; set; }
    }

    public class CrossingFigures
    {
        public static void Main()
        {
            int numberOfTests = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfTests; i++)
            {
                Circle circle = null;
                Rectangle rectangle = null;

                string firstFigure = Console.ReadLine();
                if (firstFigure.StartsWith("circle"))
                {
                    double[] args = firstFigure.Substring(6)
                        .Split(new[] { '(', ')', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .Select(n => Math.Round(n, 2))
                        .ToArray();
                    circle = new Circle(args[0], args[1], args[2]);
                }
                else
                {
                    double[] args = firstFigure.Substring(9)
                        .Split(new[] { '(', ')', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToArray();
                    rectangle = new Rectangle(args[0], args[1], args[2], args[3]);
                }

                string secondFigure = Console.ReadLine();
                if (secondFigure.StartsWith("circle"))
                {
                    double[] args = secondFigure.Substring(6)
                        .Split(new[] { '(', ')', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToArray();
                    circle = new Circle(args[0], args[1], args[2]);
                }
                else
                {
                    double[] args = secondFigure.Substring(9)
                        .Split(new[] { '(', ')', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToArray();
                    rectangle = new Rectangle(args[0], args[1], args[2], args[3]);
                }

                if (isCircleInsideRectangle(circle, rectangle))
                {
                    Console.WriteLine("Circle inside rectangle");
                }
                else if (isRectangleInsideCircle(circle, rectangle))
                {
                    Console.WriteLine("Rectangle inside circle");
                }
                else if (doCircleAndRectangleIntersect(circle, rectangle))
                {
                    Console.WriteLine("Rectangle and circle cross");
                }
                else
                {
                    Console.WriteLine("Rectangle and circle do not cross");
                }
            }
        }

        public static bool isCircleInsideRectangle(Circle circle, Rectangle rectangle)
        {
            return rectangle.A.X < circle.Center.X - circle.Radius &&
                rectangle.B.Y < circle.Center.Y - circle.Radius &&
                rectangle.B.X > circle.Center.X + circle.Radius &&
                rectangle.A.Y > circle.Center.Y + circle.Radius;
        }

        public static bool isRectangleInsideCircle(Circle circle, Rectangle rectangle)
        {
            return rectangle.A.X > circle.Center.X - circle.Radius &&
                rectangle.B.Y > circle.Center.Y - circle.Radius &&
                rectangle.B.X < circle.Center.X + circle.Radius &&
                rectangle.A.Y < circle.Center.Y + circle.Radius;
        }

        public static bool doCircleAndRectangleIntersect(Circle circle, Rectangle rectangle)
        {
            return rectangle.A.X <= circle.Center.X - circle.Radius ^
                rectangle.B.Y <= circle.Center.Y - circle.Radius ^
                rectangle.B.X >= circle.Center.X + circle.Radius ^
                rectangle.A.Y >= circle.Center.Y + circle.Radius;
        }
    }
}