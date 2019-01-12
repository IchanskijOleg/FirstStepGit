using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAreaFigures
{
    class Triangle : Shape
    {
        private int a, h;
        private double area;

        public Triangle(int a, int h)
        {
            this.a = a;
            this.h = h;
        }
        public override double GetArea()
        {
            area = 0.5 * a * h;
            Console.WriteLine("Площа трикутника = " + area);
            return area;
        }
    }
}
