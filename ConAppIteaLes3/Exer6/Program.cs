using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer6
{
    class Program
    {
        /* Задача №6
           Дано четыре числа, 
           если первые два числа больше 5, 
           третье число делится на 6, 
           четвертое число не делится на 3, то вывести yes, иначе no.
         */
        static void Main(string[] args)
        {
            int a = 8, b = 10, c = 6, d = 5;

            if (a > 5 && b > 5 && c % 6 == 0 && d % 3 != 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();
        }
    }
}
