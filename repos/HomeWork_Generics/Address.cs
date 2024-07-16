using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Generics
{
    class Address
    {
        private string index, country, city, street, house, apartment;

        public string Index
        {
            get => index;
            set => index = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Street
        {
            get => street;
            set => street = value;
        }

        public string House
        {
            get => house;
            set => house = value;
        }

        public string Apartment
        {
            get => apartment;
            set => apartment = value;
        }
    }
}
