using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer5
{
    class Program
    {
        /* Задача №5
           Даны три числа. Написать "yes", если можно взять какие-то два из них и в сумме получить третье
         */
        static void Main(string[] args)
        {
            int a = 5, b = 4, c = 1;

            if (a + b == c || a + c == b || b + c == a)
            {
                Console.WriteLine("yes");
            }
            Console.ReadKey();
        }
    }
}
