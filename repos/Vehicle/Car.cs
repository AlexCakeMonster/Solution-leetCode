using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car : Vehicle
    {
        public new void Show()
        {
            Console.WriteLine("Vehicle Information: ");
            base.Show();            
        }
    }
}
