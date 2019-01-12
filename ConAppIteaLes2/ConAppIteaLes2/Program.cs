using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppIteaLes2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8; 
            double res;
            res = Math.Pow(3, 3);
            int i = 2 + 2;
            Console.WriteLine($" i = {i} и res = {res} и Math.Pow = {Math.Pow(3, 3)}");

            var v = 10;
            //v = ""; ОШИБКА

            Console.ReadKey();
        }
    }
}
