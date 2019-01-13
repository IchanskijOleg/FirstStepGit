using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer9PrintRectangle
{
    class Program
    {
        /*
        Задача №9
        Вывести на экран прямоугольник, заполненный буквами А. 
        Количество строк в прямоугольнике равно 5, количество столбцов равно 8.
        Не использовать циклы.
        */
        static void Main(string[] args)
        {
            int x = 1, y = 1;

            PrintA:

            if (y <= 8 )
            {
                Console.Write('A');
                y++;
                goto PrintA;
            }
            Console.WriteLine();
            if (x < 5)
            {
                y = 1;
                x++;
                goto PrintA;
            }
            
            Console.ReadKey();
        }
    }
}
