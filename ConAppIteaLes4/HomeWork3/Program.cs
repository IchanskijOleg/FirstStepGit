using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        /*
        Задача №3
            Вывести на экран:
            AAAAAAAAAAAAAAAA
            ABBBBBBBBBBBBBBA
            ABBBBBBBBBBBBBBA
            ABBBBBBBBBBBBBBA
            AAAAAAAAAAAAAAAA
            (количество строк вводит пользователь, ширина прямоугольника в два раза больше высоты)
        */
        static void Main(string[] args)
        {
            const char sA = 'A';
            const char sB = 'B';
            int h = 0, len = 0;
            string printLine;

            Console.WriteLine("Уведіть кількість рядків");
            h = Convert.ToInt32(Console.ReadLine());
            len = h * 2;

            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= len; j++)
                {
                    printLine = (i == 1) || (i == h) || (j == 1) || (j == len) ? sA.ToString() : sB.ToString();
                    Console.Write(printLine);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
