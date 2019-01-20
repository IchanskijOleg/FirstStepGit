using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        /*
        Задача №5
        Пользователь вводит ненулевые целые числа до тех пор, пока не введет ноль. Найдите количество четных чисел, которые он ввел.
        */
        static void Main(string[] args)
        {
            int n = 0, count = 0;
            do
            {
                Console.WriteLine("Уведыть число. Щоб вийти уведыть 0");
                n = Convert.ToInt32(Console.ReadLine());
                if (n==0)
                {
                    break;
                }
                count += n % 2 == 0 ? 1 : 0;
            } while (n!=0);
            Console.WriteLine("Кількість парних чисел = {0}", count);
            Console.ReadKey();
        }
    }
}
