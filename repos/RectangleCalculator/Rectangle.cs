using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleCalculator
{
    class Rectangle
    {
        double side1, side2, area, perimeter;

        public double Area { get => area; }
        public double Perimeter { get => perimeter; }


        public Rectangle() { }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            AreaCalculator();
            PerimeterCalculator();
        }

        public double AreaCalculator()
        {
            
            area = side1 * side2;
            return area;
        }

        public double PerimeterCalculator()
        {            
            perimeter = side1 * 2 + side2 * 2;
            return perimeter;
        }
    }
}
