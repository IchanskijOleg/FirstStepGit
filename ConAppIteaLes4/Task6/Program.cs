using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        /// <summary>
        /// Виводимо на екран квадрат по діагоналі якого стоять нулі
        /// </summary>
        /// <param name="a">Сторона квадрата</param>
        static void PrintSquare(int a)
        {
            for (int i = 1; i < a; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    if (i == j)
                    {
                        Console.Write('0');
                    }
                    else
                    {
                        Console.Write('1');
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вивід рядків з умовами :)
        /// </summary>
        /// <param name="a">Кількість рядків</param>
        static void PrintLine(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int j = 0; j <= a; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(1);
                    }
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Друкуємо таблицю множення
        /// </summary>
        static void PrintTableMult(int a)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // друкуємо квадрат
            PrintSquare(10);
            // друкуємо таблицю множення
            PrintTableMult(10);
            // друкуємо рядки
            PrintLine(20);

            Console.ReadKey();
        }
    }
}
