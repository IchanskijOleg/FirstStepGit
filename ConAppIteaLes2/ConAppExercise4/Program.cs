using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4Square
{
    class Program
    {
        /*
        Задача №4
        Пользователь вводит сторону квадрата. Найдите периметр и площадь квадрата.
        */
        static void Main(string[] args)
        {
            int a = 0, area = 0, per = 0;

            Console.WriteLine("Уведіть сторону квадрата");
            a = Convert.ToInt32(Console.ReadLine());

            area = a * a;
            per = 4 * a;

            Console.WriteLine("Плаща квадрата з стороною {0} = {1}, периметр =  {2}", a, area, per);

            Console.ReadKey();
        }
    }
}
