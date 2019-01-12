using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAreaFigures
{
    class Square : Shape
    {
        private int a;
        private double area;

        public Square(int a)
        {
            this.a = a;
        }
        public override double GetArea()
        {
            area = a * a;
            Console.WriteLine("Площа квадрата = " + area);
            return area;
        }
    }
}
