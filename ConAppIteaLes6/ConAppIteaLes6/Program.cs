using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppIteaLes6
{
    class Program
    {
        static void Main(string[] args)
        {
            string index;
            string country;
            string street;
            string house;
            string apartment;

            Console.WriteLine("Уведіть Індекс");
            index = Console.ReadLine();
            Console.WriteLine("Уведіть місто");
            country = Console.ReadLine();
            Console.WriteLine("Уведіть вулицу");
            street = Console.ReadLine();
            Console.WriteLine("Уведіть будинок");
            house = Console.ReadLine();
            Console.WriteLine("Уведіть квартиру");
            apartment = Console.ReadLine();

            Adress address = new Adress(index, country, street, house, apartment);
            address.PrintAdress();

             Console.ReadKey();
        }
    }
}
