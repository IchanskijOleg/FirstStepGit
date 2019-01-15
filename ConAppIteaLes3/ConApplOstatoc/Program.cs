using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApplOstatoc
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0,
                num2 = 0,
                num3 = 0,
                num4 = 0,
                res = 0;

            Console.WriteLine("Уведіть num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Уведіть num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Уведіть num3");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Уведіть num4");
            num4 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0 || num2 % 2 == 0 || num3 % 2 == 0 || num4 % 2 == 0)
            {
                res = (num1 % 2 == 0) ? (res > num1 ? res: num1) : res;
                res = (num2 % 2 == 0) ? (res > num2 ? res : num2) : res;
                res = (num3 % 2 == 0) ? (res > num3 ? res : num3) : res;
                res = (num4 % 2 == 0) ? (res > num4 ? res : num4) : res;
                
                Console.WriteLine("Максимальне парне число з ({0},{1},{2},{3}) = {4}", num1, num2, num3, num4, res);
            }
            else
            {
                Console.WriteLine("Немає цілого числа");
            }

            Console.ReadKey();
        }
    }
}
