using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Rectangle
    {
        private double side1, side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;

            double CalculatePerimeter()
            {
                return 2 * (side1 + side2);
            }
            double CalculateArea()
            {
                return side1 * side2;
            }
        }

        public double GetPerimeter
        {
            get { return 2 * (side1 + side2); }
        }
        public double GetArea
        {
            get { return side1 * side2; }
        }
    }
}
