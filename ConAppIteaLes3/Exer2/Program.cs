using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2
{
    class Program
    {
        /* Задача №2
           Даны три числа. Написать "yes", если среди них есть одинаковые.
         */
        static void Main(string[] args)
        {
            int a = 1, b = 1, c = 0;
            if (a == b)
            {
                Console.WriteLine("yes");
            }
            else if (a == b)
            {
                Console.WriteLine("yes");
            }
            else if (a == c)
            {
                Console.WriteLine("yes");
            }
            else if (b == c)
            {
                Console.WriteLine("yes");
            }

            Console.ReadKey();
        }
    }
}
