using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        /// <summary>
        /// Вивід на екран рівностороннього трикутника
        /// </summary>
        /// <param name="h">Висота трикутника</param>
        public static void PrintTriagle(int h)
        {
            int x = h * 2 - 1; //довжина сторони
            int peakStart = x;
            int peakEnd = x;

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < 2 * x + 1; j++)
                {
                    if (peakStart < 1.5 * x && j >= peakStart && j <= peakEnd)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                peakStart--;
                peakEnd++;
                Console.WriteLine("");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Уведіть сторону рівностороннього трикутника:");
            int h = Convert.ToInt32(Console.ReadLine());
            PrintTriagle(h);

            Console.ReadKey();
        }
    }
}
