using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer7
{
    class Program
    {
        /* Дано четырехзначное число. 
         * Верно ли, что цифр в нем расположены по убыванию? 
         * Например, 4311 - нет, 4321 - да, 5542 - нет, 5631 - нет, 9871 - да.
         */
        static void Main(string[] args)
        {
            int a = 4310; 
            if (a < 10000)
            {
                /*Console.WriteLine(a / 1000);
                Console.WriteLine((a - (a / 1000) * 1000) / 100);
                Console.WriteLine((a - (a / 100) * 100) / 10);
                Console.WriteLine((a - (a / 10) * 10) / 1); */
 
                if ((a / 1000) > ((a - (a / 1000) * 1000) / 100) && ((a - (a / 100) * 100) / 10) > ((a - (a / 10) * 10) / 1))
                {
                    Console.WriteLine("расположены по убыванию");
                }
            }

            Console.ReadKey();
        }
    }
}
