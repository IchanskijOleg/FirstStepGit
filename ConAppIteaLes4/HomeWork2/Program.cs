using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        /*
        Задача №2
            Вывести на экран:
            AAABBBAAABBBAAABBB
            BBBAAABBBAAABBBAAA
            AAABBBAAABBBAAABBB
            (таких строк n, в каждой строке m троек AAA)
        */
        static void Main(string[] args)
        {
            const string sAAA = "AAA";
            const string sBBB = "BBB";
            int n = 0, m = 0;
            string printLine;

            Console.WriteLine("Уведіть кількість рядків");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Уведіть кількість пар трійок ААА");
            m = Convert.ToInt32(Console.ReadLine());

            for (int i = 1, k = 1; i <= n; i++)
            {
                printLine = (i % 2 == 0) ? sBBB + sAAA : sAAA + sBBB;
                while (k <= m)
                {
                    Console.Write(printLine);
                    k++;
                }
                Console.WriteLine();
                k = 1;
            }
            Console.ReadKey();
        }
    }
}
