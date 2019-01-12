using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppFigure
{
    /* Написать программу, которая выводит на экран название и периметр многоугольника. */
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(0, 0, "a");
            Point b = new Point(1, 1, "b");
            Point c = new Point(1, 2, "c");
            Figure f = new Figure(a, b, c);
            Console.WriteLine("FigureLength = " + f.Length);

            Console.ReadKey();
        }
    }
}
