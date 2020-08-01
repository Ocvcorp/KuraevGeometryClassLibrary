using System;


namespace KuraevGeometryClassLibrary
{

    public class Triangle2D : Shape2D
    {
        public Triangle2D(double a, double b, double c) : base("Triangle")
        {
            if ((c >= a + b) || (b >= a + c) || (a >= c + b))
                throw new Exception("Неверный ввод длин сторон");
            this.a = a;
            this.b = b;
            this.c = c;
            if ((c * c == a * a + b * b) || (a * a == c * c + b * b) || (b * b == c * c + a * a))
                IsRectangular = true;
        }
        public bool IsRectangular { get; }
        private double a, b, c;
        public override double GetArea()
        {
            double area;
            double p = (a + b + c)/2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }


    public class Circle2D : Shape2D
    {
        public Circle2D(double radius) : base("Circle")
        {
            this.radius =  radius;
        }
        private double radius;
        public override double GetArea()
        {
            double area;
            area = Math.PI * radius * radius;
            return area;
        }
    }
}
