using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer5Speed
{
    /*
    Задача №5
    Пользователь вводит время в минутах и расстояние в километрах. 
    Найдите скорость в м/c.
    */
    class Program
    {
        static void Main(string[] args)
        {
            double v = 0, // швидкість
                   s = 0, // шлях
                   t = 0; // час

            Console.WriteLine("Уведіть час в хвилинах");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Уведіть відстань в кілометрах");
            s = Convert.ToDouble(Console.ReadLine());

            t *= 60;
            s *= 100;
            v = s / t;

            Console.WriteLine("Швидкість =  {0}м/c", v);

            Console.ReadKey();
        }
    }
}
