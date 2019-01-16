using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer9
{
    class Program
    {
        /*Робот может перемещаться в четырех направлениях («11» — север, «12» — запад, «13» — юг, «14» — восток) и принимать три цифровые команды: 
         * 0 — продолжать движение, 
         * 1 — поворот налево, 
         * -1 — поворот направо. 
         * Дан число (11, 12, 13 или 14) — исходное направление робота и целое число N (0, 1 или -1) — посланная ему команда. 
         * Вывести направление робота после выполнения полученной команды (то есть север, запад, юг или восток).
         */
        static void Main(string[] args)
        {
            const int north = 11; // север
            const int west = 12; // запад
            const int south = 13; // юг
            const int east = 14; // восток
            int startPoint, nextPoint;

            Console.WriteLine("Введіть початкове направлення робота «11» — север, «12» — запад, «13» — юг, «14» — восток");
            startPoint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть направлення 0 — продолжать движение; 1 — поворот налево; -1 — поворот направо");
            nextPoint = Convert.ToInt32(Console.ReadLine());

            if ((startPoint == north || startPoint == west || startPoint == south || startPoint == east) && (nextPoint == -1 || nextPoint == 1 || nextPoint == 0))
            {
                switch (startPoint + nextPoint)
                {
                    case north:
                        Console.WriteLine("север");
                        break;
                    case west:
                        Console.WriteLine("запад");
                        break;
                    case south:
                        Console.WriteLine("юг");
                        break;
                    default:
                        Console.WriteLine("восток");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ввели невірний напрямок");
            }
            Console.ReadKey();
        }
    }
}
