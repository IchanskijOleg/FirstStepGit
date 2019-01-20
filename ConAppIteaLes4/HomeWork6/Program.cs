using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        /*
        Задача №6
        Вычислите значения функции f(x)=x2−sinx на отрезке [a;b] с шагом h. 
        Результат представить в виде таблицы.
        */
        static void Main(string[] args)
        {
            Console.Write("Введите начало отрезка a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите конец отрезка b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите шаг h = ");
            double h = double.Parse(Console.ReadLine());
            double x = a;
            double y;
            double min = double.MaxValue;
            double max = double.MinValue;
            while (x <= b)
            {
                y = Math.Pow(x, 2) * Math.Sin(x);

                if (y < min) min = y;
                if (y > max) max = y;
                Console.WriteLine("{0}\t{1}", x, y);
                x += h;
            }
            Console.WriteLine("Минимальное значение функции на отрезке: {0}", min);
            Console.WriteLine("Максимальное значение функции на отрезке: {0}", max);

            Console.ReadKey();
        }
    }
}
