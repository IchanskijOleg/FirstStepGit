using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer10
{
    class Program
    {
        /* Даны два прямоугольника, стороны которых параллельны или перпендикулярны осям координат. 
           Известны координаты левого нижнего угла каждого из них и длины их сторон. 
           Один из прямоугольников назовем первым, другой — вторым.
           а) Определить, принадлежат ли все точки первого прямоугольника второму.
           б) Определить, принадлежат ли все точки одного из прямоугольников другому.
           в) Определить, пересекаются ли эти прямоугольники.
         */

        /// <summary>
        /// Метод який визначає чи перетинаються прямокутники
        /// </summary>
        /// <param name="A">Перший прямокутник</param>
        /// <param name="B">Другий прямокутник</param>
        public static void IsIntersect(Rectangle RectA, Rectangle RectB)
        {
            /*if (RectB.p3.X > RectB.p1.X)and(RectB.p3.Y < RectB.p1.Y)
            {
            } ;*/
            if ((RectA.p1.X == RectB.p1.X) && (RectA.p3.X == RectB.p3.X) && (RectA.p1.Y == RectB.p1.Y) && (RectA.p3.Y == RectB.p3.Y))
            {
                Console.WriteLine("Прямоугльники совпадают");
            }
            else
            {
                /*if ((((RectA.p1.X == RectB.p1.X) || (RectA.p3.X == RectB.p3.X)) && ((RectB.p1.Y <= RectA.p1.Y) && (RectB.p1.Y >= RectA.p3.Y)) || (((RectB.p3.Y <= RectA.p1.Y) && (RectB.p3.Y >= RectA.p3.Y))))
                    || (((RectA.p1.Y == RectB.p1.Y) || (RectA.p3.Y == RectB.p3.Y)) && ((RectB.p1.X >= RectA.p1.X) && (RectB.p1.X <= RectA.p3.X)) || (((RectB.p3.X >= RectA.p1.X) && (RectB.p3.X <= RectA.p3.X)))))
                {
                    Console.WriteLine("Прямоугольники соприкасаются");
                }
                else
                {
                    Console.WriteLine("Прямоугольники не соприкасаются");
                }*/

                if ((RectA.p1.X >= RectB.p1.X) && (RectA.p3.X <= RectB.p3.X) && (RectA.p1.Y <= RectB.p1.Y) && (RectA.p3.Y >= RectB.p3.Y))
                {
                    Console.WriteLine("Первый прямоугольник внутри второго");
                }
                else if ((RectB.p1.X >= RectA.p1.X) && (RectB.p3.X <= RectA.p3.X) && (RectB.p1.Y <= RectA.p1.Y) && (RectB.p1.Y >= RectA.p3.Y))
                {
                    Console.WriteLine("Второй прямоугольник внутри первого");
                }
                else
                {
                    Console.WriteLine("Прямоугольники пересекаются");
                }
            }
        }

        static void Main(string[] args)
        {
            /*int x1, y1, x2, y2, a1, b1, a2, b2;
            Console.WriteLine("Введите координаты левого верхнего угла первого прямоугольника:");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите длину стороны a по x:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину стороны b по y:");
            b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты левого верхнего угла первого прямоугольника:");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите длину стороны a по x:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину стороны b по y:");
            b2 = Convert.ToInt32(Console.ReadLine());*/

            Rectangle rectA = new Rectangle(0, 0, 5, 2);
            Rectangle rectB = new Rectangle(1, 1, 3, 2);
            // Определим свойства прямоугольников а),б),в)
            IsIntersect(rectA, rectB);

            Console.ReadKey();
        }
    }
}
