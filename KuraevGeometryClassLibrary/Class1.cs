using System;
using System.Collections.Generic;

namespace KuraevGeometryClassLibrary
{
    public class Point2D
    {
        Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }
    }
    public interface IPointShape2D
    {
        public string Type { get; set; }
        public List<Point2D> Points { get; set; }
        public double Area();
    }
    public class Triangle2D
    {
        public Triangle2D(double a, double b, double c)
        {
            if ((c >= a + b) || (b >= a + c) || (a >= c + b))
                throw new Exception("Неверный ввод");

            if ((c > a) && (c > b) && (c * c == a * a + b * b))
            {
                IsRectangular = true;
                Area = a * b / 2;
            }
            else if ((a > c) && (a > b) && (a * a == c * c + b * b))
            {
                IsRectangular = true;
                Area = c * b / 2;
            }
            else if (b > c && b > a && b * b == c * c + a * a)
            {
                IsRectangular = true;
                Area = c * a / 2;
            }
            else
            {
                IsRectangular = false;
                double p = a + b + c;
                Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }


        }
        public double Area { get; }
        public bool IsRectangular { get; }
    }

    public class Circle2D
    {

    }
}
