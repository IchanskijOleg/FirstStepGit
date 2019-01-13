using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3ThreeNumbers
{
    class Program
    {
        /* 
        Задача №3
        Пользователь вводит три числа. 
        Увеличьте первое число в два раза, 
        второе числа уменьшите на 3, 
        третье число возведите в квадрат 
        и затем найдите сумму новых трех чисел.
        */
        static void Main(string[] args)
        {
            double x = 0, y = 0, z = 0, sum = 0;

            Console.WriteLine("Уведіть перше число");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Уведіть друге число");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Уведіть третє число");
            z = Convert.ToDouble(Console.ReadLine());

            x = x * 2;
            y = y / 3;
            z = Math.Pow(z, 2);
            sum = x + y + z;

            Console.WriteLine("Cума чисел {0}, {1} і {2} = {3}", x, y, z, sum);

            Console.ReadKey();
        }
    }
}
