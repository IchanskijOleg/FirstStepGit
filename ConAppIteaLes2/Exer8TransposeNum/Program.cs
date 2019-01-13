using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer8TransposeNum
{
    class Program
    {
        /* 
        Задача №8
        Поменяйте местами значения двух переменных, не используя дополнительных переменных.
        */
        static void Main(string[] args)
        {
            int a = 1, 
                b = 2;

            Console.WriteLine("a = {0}, b = {1}", a, b);

            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine("a = {0}, b = {1}", a, b);

            Console.ReadKey();
        }
    }
}
