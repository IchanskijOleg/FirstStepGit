using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_MethodABC
{
    class Program
    {
        /*
        ЗАДАЧА №2
        Заданы три числа: a, b, c. Необходимо выяснить, можно ли так переставить цифры в числах a и b, чтобы в сумме получилось c.
        */
        public static void IsNumberCResultAPlusB(int a, int b, int c)
        {
            if ((a / 10 + (a % 10) * 10 + b == c) ||
                 (a + b / 10 + (b % 10) * 10 == c) ||
                 (a / 10 + (a % 10) * 10 + b / 10 + (b % 10) * 10 == c))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("not");
            }
        }
        static void Main(string[] args)
        {
            int a = 12;
            int b = 10;
            int c = 2;

            IsNumberCResultAPlusB(a, b, c);

            Console.ReadKey();
        }
    }
}
