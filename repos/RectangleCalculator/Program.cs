using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(10, 5);

            //Console.WriteLine(rectangle1.AreaCalculator());
            
            Console.WriteLine(rectangle1.Area);

            Console.ReadKey();
        }
    }
}
