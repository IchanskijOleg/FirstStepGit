using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1Formula
{
    class Program
    {
        /* 
        Задача №1
        Вычислите значение выражения(a+4b)(a−3b)+a2("а" в квадрате) при a = 2 и b = 3.
        */
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            double res;
            res = (a + 4 * b) * (a - 3 * b) + Math.Pow(a, 2);
            Console.WriteLine("(a+4b)(a-3b)+a2 = {0}", res);

            Console.ReadKey();
        }
    }
}
