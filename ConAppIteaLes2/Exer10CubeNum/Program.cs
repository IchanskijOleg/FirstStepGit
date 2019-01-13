using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer10CubeNum
{
    class Program
    {
        /*
        Задача №10
        Пользователь вводит число. Выведите на экран квадрат этого числа, куб этого числа.
        */
        static void Main(string[] args)
        {
            int x = 0;
            double cube = 0, square = 0;

            Console.WriteLine("Уведіть число");
            x = Convert.ToInt32(Console.ReadLine());

            square = Math.Pow(x, 2);
            cube = Math.Pow(x, 3);

            Console.WriteLine("Квадрат числа = {0}, в кубі = {1}", square, cube);

            Console.ReadKey();
        }
    }
}
