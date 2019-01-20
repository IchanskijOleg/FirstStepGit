using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        /*
            Задача №4
            Найдите четырехзначные числа, сумма цифр которых равна 15.
        */
        static void Main(string[] args)
        {
            int temp = 0;

            for (int number = 1000; number <= 9999; number++)
            {
                number.ToString().ToCharArray();
                foreach (var VARIABLE in number.ToString().ToCharArray())
                {
                    temp += Convert.ToInt32(VARIABLE.ToString());
                }
                if (temp == 15)
                {
                    Console.WriteLine("Сумма числa {0}, равна 15", number);
                }
                temp = 0;
            }
            Console.ReadKey();
        }
    }
}
