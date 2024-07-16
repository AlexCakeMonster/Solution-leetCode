using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {       
        double speed;
        int price, yearOfssue;
        string coordinates;

        public string Coordinates
        {         
            set => coordinates = value;
        }

        public double Speed
        {
            set => speed = value;
        }

        public int Price
        {
            set => price = value;
        }

        public int YearOfssue
        {
            set => yearOfssue = value;
        }

        protected void Show()
        {
            Console.WriteLine($"Coordinates: {coordinates}.\nSpeed: {speed}.\nPrice: {price}.\nYear of ssue: {yearOfssue}");
        }
    }
}
