using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Fibonachi
{
    class Program
    {
        /*
        По заданному числу N вычислить число Фибоначчи F(N).
        */
        public static int GetFibonachi(int n)
        {
            int res = n;
            if (n > 0)
            {
                res = res + GetFibonachi(n - 1);
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetFibonachi(3));
            Console.ReadKey();
        }
    }
}
