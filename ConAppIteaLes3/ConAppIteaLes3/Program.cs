using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppIteaLes3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*switch (2)
            {
                case 1:
                    Console.WriteLine(1);
                    Console.WriteLine(2);
                    break;
                case 2:
                    Console.WriteLine(3);
                    Console.WriteLine(4);
                    break;
                default:
                    Console.WriteLine(5);
                    break;
            }*/

            double x = 0, y = 0;

            Console.WriteLine("Vvedite x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite y");
            y = Convert.ToDouble(Console.ReadLine());

            if (y < 0)
            {
                Console.WriteLine("Корінь відємного числа не існує");
            }
            else
            {
                if ((x - Math.Sqrt(y)) < 0)
                {
                    Console.WriteLine("Корінь відємного числа не існує");
                }
                else
                {
                    Console.WriteLine(Math.Sqrt(x - Math.Sqrt(y)));
                }
            }


            Console.ReadKey();
        }
    }
}
