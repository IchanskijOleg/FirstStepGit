using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Address addr = new Address();
            addr.Index = "5656";
            addr.Country = "Ukraine";
            addr.City = "Kiev";
            addr.Street = "Lobanovskoho";
            addr.House = "24";
            addr.Apartment = "124";

            Console.WriteLine("index = {0}, country = {1}, city = {2}, street = {3}, house = {4}, apartment = {5}",
                              addr.Index, addr.Country, addr.City, addr.Street, addr.House, addr.Apartment);
            Console.ReadKey();
        }
    }
}
