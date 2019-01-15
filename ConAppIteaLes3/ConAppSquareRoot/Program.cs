using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a = 1, b = -6, c = 34, x = 0, d;
            double a = 1, b = -2, c = -3, x = 0, d;
            // дискриминан
            d = Math.Pow(b, 2) - 4 * a * c;
            // рівняння має 1 корінь
            if (d == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine(x);
            }

            else if (d > 0)
            {
                x = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = {0}", x);
                x = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x2 = {0}", x);
            }
            else
            {
                Console.WriteLine("Коренів немає");
            }

            Console.ReadKey();

        }
    }
}
