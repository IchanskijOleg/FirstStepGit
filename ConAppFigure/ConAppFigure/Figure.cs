using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppFigure
{
    class Figure
    {
        private double length;
        public double Length { get { return length; } }
        public double Name { get; }

        public Figure(Point p1, Point p2)
        {
            length = LengthSide(p1, p2);
        }
        public Figure(Point p1, Point p2, Point p3)
        {
            length = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p1);
        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
            : this(p1, p2, p3)
        {
            length += LengthSide(p3, p4) + LengthSide(p4, p1);
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
            : this(p1, p2, p3, p4)
        {
            length += LengthSide(p4, p5) + LengthSide(p5, p1);
        }
        /// <summary>
        /// метод который рассчитывает длину стороны многоугольника(длина отрезка)
        /// </summary>
        /// <param name="A">первая точка</param>
        /// <param name="B">вторая точка</param>
        /// <returns></returns>
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }
        /// <summary>
        /// метод который рассчитывает периметр многоугольника
        /// </summary>
        public void PerimeterCalculator() { }
    }
}
