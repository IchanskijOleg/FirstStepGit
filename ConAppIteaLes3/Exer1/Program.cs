using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1
{
    class Program
    {
        /* Задача №1
           Дано число. Если оно больше 3, то увеличить число на 10, иначе уменьшить на 10.
        */
        static void Main(string[] args)
        {
            int a = 2;
            if (a > 3)
            {
                a += 10;
            }
            else
            {
                a -= 10;
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
