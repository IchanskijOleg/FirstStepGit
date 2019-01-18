using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer10
{
    class Rectangle
    {
        private int x, y, a, b;
        public Point p1; // Ліва нижня точка прямокутника
        public Point p3; // Права верхня точка прямокутника
        public Rectangle(int x, int y, int a, int b)
        {
            this.x = x;
            this.y = y;
            this.a = a;
            this.b = b;
            p1 = new Point(x, y);
            p3 = new Point(x + a, y + b);
        }
    }
}
