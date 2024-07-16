using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Ship : Vehicle
    {
        string homePort;
        int numberOfPassengers;

        public string HomePort
        {
            set => homePort = value;
        }

        public int NumberOfPassengers
        {
            set => numberOfPassengers = value;
        }

        public new void Show()
        {
            Console.WriteLine("Aircraft information: ");
            base.Show();
            Console.WriteLine($" Home Port: {homePort} \nNumber of passengers: {numberOfPassengers} ");
        }
    }
}
