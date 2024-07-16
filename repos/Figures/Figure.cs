using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Figure
    {
        Point point1, point2, point3, point4, point5;

        private double perimeter;

        private string figure;

        public string Perimeter()
        {
            return $"{figure} perimeter = {perimeter}";
        }    

        public Figure(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            figure = "Triangle";
            PerimeterCalculatorTriangle();
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            figure = "Quadrangle";
            PerimeterCalculatorQuadrangle();
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            this.point5 = point5;
            figure = "Pentagon";
            PerimeterCalculatorPentagon();

        }

        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y),2));
        }

        private void PerimeterCalculatorTriangle() => perimeter = LengthSide(point1, point2) +
            LengthSide(point2, point3) + LengthSide(point3, point1);



        private void PerimeterCalculatorQuadrangle() => perimeter = LengthSide(point1, point2) + 
            LengthSide(point2, point3) + LengthSide(point3, point4) + LengthSide(point4, point1);


        private void PerimeterCalculatorPentagon() => perimeter= LengthSide(point1, point2) +
            LengthSide(point2, point3) + LengthSide(point3, point4) + LengthSide(point4, point5) + LengthSide(point5, point1);

    }
}
