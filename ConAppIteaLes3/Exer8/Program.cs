using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer8
{
    class Program
    {
        /*Задача №8
          Пользователь вводит три числа - длины сторон треугольника. Найти площадь треугольника. 
          Сделать проверку на существование треугольника (например, 1, 2, 3 - такого треугольника не существует). 
         */
        static void Main(string[] args)
        {
            double a = 8, b = 10, c = 6, area = 0, p = 0;
            if (a + b > c && a + c > b && b + c > a)
            {
                // периметр
                p = (a + b + c) / 2;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Площа трикутника = {0}", area);
            }
            else
            {
                Console.WriteLine("Трикутника не існує");
            }
            Console.ReadKey();
        }
    }
}
