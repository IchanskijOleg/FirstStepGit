using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3
{
    class Program
    {
        /* Задача №3
           Даны три числа. Найдите те два из них, сумма которых наибольшая.
         */
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 5;
            if (a + b > a + c)
            {
                if (a + b > b + c)
                {
                    Console.WriteLine("a + b");
                }
                else
                {
                    Console.WriteLine("b + c");
                }

            }
            else if (a + c > b + c)
            {
                Console.WriteLine("a + c");
            }
            else
            {
                Console.WriteLine("b + c");
            }
            Console.ReadKey();
        }
    }
}
