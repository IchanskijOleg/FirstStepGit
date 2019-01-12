using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAreaFigures
{
    class Program
    {
        static void Main(string[] args)
        {

            string conReadkey;

            do
            {
                Console.WriteLine("Виберіть фігуру:");
                Console.WriteLine("1 - Квадрат; 2 - Трикутник;");
                conReadkey = Console.ReadLine();
            }
            while  (!(conReadkey == "1" || conReadkey == "2"));


            Shape sh;
            if (conReadkey == "1")
            {
                sh = new Square(3);
            }
            else
            {
                sh = new Triangle(5, 2);
            }
            sh.GetArea();

            Console.ReadKey();
        }
    }
}
