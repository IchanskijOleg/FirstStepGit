using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(2, 3);
            Console.WriteLine("Площа = {0}", rec.Area);
            Console.WriteLine("Периметер = {0}", rec.Perimeter);

            Console.ReadKey();
        }
    }
}
