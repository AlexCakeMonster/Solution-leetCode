using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Plane : Vehicle
    { 
        int flightAltitude, numberOfPassengers;

        public int HlightAltitude
        {
            set => flightAltitude = value;           
        }

        public int NumberOfPassengers
        {
            set => numberOfPassengers = value;
        }

        public new void Show()            
        {
            Console.WriteLine("Aircraft information: ");
            base.Show();
            Console.WriteLine($"Flight altitude: {flightAltitude} \nNumber of passengers: {numberOfPassengers} ");
        }
    }
}
