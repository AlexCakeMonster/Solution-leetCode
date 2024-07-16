using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(0, 0), new Point(0, 2), new Point(2, 2), new Point(2, 0), new Point(1,-1));

            Console.WriteLine(figure.Perimeter());
            Console.ReadKey();
        }
    }
}
