using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppIteaLes6
{
    class Adress
    {
        /*private string index;
        private string country;
        private string street;
        private string house;
        private string apartment;*/

        public string Index { get; }
        public string Country { get; }
        public string Street { get; }
        public string House { get; }
        public string Apartment { get; }

        public Adress(string index, string country, string street, string house, string apartment)
        {
            Index = index;
            Country = country;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public void PrintAdress()
        {
            Console.WriteLine("Індекс {0}, місто {1}, вулиця {2}, будинок {3}, квартира {4}", Index, Country, Street, House, Apartment);
        }
    }
}
