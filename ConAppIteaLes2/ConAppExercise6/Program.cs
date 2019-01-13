using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer6Fahrenheit
{
    /*
    Задача №6
    Дано значение температуры в градусах Цельсия. 
    Вывести температуру  в градусах Фаренгейта.
    */
    class Program
    {
        static void Main(string[] args)
        {
            double c = 0, // Цельсия
                   f = 0; // Фаренгейта

            Console.WriteLine("Уведіть температуру в Цельсіях");
            c = Convert.ToDouble(Console.ReadLine());

            f = (c * 9 / 5) + 32;

            Console.WriteLine("температуру Фаренгейта = {0}", f);

            Console.ReadKey();
        }
    }
}
