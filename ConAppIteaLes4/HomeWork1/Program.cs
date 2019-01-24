using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        /*Задача №1
            Выведите на экран строки вида:
            *******
            ****
            *******
            ****
            *******
            ****
            (всего n строк, звездочек или 7, или 4 по очереди)
        */
        static void Main(string[] args)
        {
            const int asterisk7 = 7,
                      asterisk4 = 4;
            int n = 0;

            Console.WriteLine("Уведіть кількість рядків");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(new string('*', asterisk4));
                }
                else
                {
                    Console.WriteLine(new string('*', asterisk7));
                }
            }
            Console.ReadKey();
        }
    }
}
