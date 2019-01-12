using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppFigure
{
    class Point
    {
        private string s;
        private int x, y;
        public string S { get { return s; }  }
        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Point(int x, int y, string s)
        {
            this.x = x;
            this.y = y;
            this.s = s;
        }
    }
}
