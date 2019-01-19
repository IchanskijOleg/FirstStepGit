using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Test(ref int a, out int b)
        {
            b = 5;
            a = 10;
            Console.WriteLine();            
        }
        static void Main(string[] args)
        {
            int x = 0, y = 1;
            Test(ref x, out y);
        }
    }
}
