using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Figure
    {

        private Point[] points;
        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[3] { p1, p2, p3 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[4] { p1, p2, p3, p4 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[5] { p1, p2, p3, p4, p5 };
        }

        public double GetSideLength(Point A, Point B)
        {
            return (Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
        public void CalculatePerimeter()
        {
            double perimeter = 0;
                for (int i = 0; i < points.Length; i++)
                {
                    int nextIndex = (i + 1) % points.Length;
                    perimeter += GetSideLength(points[i], points[nextIndex]);
                }
            Console.WriteLine(points.Length);
            Console.WriteLine(perimeter);
        }
    }
}
