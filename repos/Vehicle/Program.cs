using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane1 = new Plane();
            plane1.Coordinates = "35, 54, 90";
            plane1.Speed = 700;
            plane1.HlightAltitude = 8000;
            plane1.NumberOfPassengers = 100;
            plane1.Price = 200000;
            plane1.YearOfssue = 1984;
            Car car1 = new Car();
            car1.Coordinates = "56,84,52";
            car1.Speed = 120;
            car1.Price = 500;
            car1.YearOfssue = 1996;
            plane1.Show();
            car1.Show();
            Console.ReadKey();
           
        }
    }
}
