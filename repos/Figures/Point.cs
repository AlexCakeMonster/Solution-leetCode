using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Point
    {
        double x, y;        

        public double X
        {
            get => x;
        }

        public double Y
        {
            get => y;
        }
       

        public Point() { }

        public Point(int x, int y)
        {            
            this.x = x;
            this.y = y;
        }

    }
}
