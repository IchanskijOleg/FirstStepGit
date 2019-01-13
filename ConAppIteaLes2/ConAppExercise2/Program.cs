using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2SumTwoNumbers
{
    class Program
    {
        /* 
        Задача №2
        Пользователь вводит два числа. Найдите сумму и произведение данных чисел.
        */
        static void Main(string[] args)
        {
            int x = 0, y = 0, sum = 0, mult = 0;

            Console.WriteLine("Уведіть перше число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Уведіть друге число");
            y = Convert.ToInt32(Console.ReadLine());

            sum = x + y;
            mult = x * y;

            Console.WriteLine("Cума чисел {0} i {1} = {2}", x, y, sum);
            Console.WriteLine("Добуток чисел {0} i {1} = {2}", x, y, mult);

            Console.ReadKey();
        }
    }
}
