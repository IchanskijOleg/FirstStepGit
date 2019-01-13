using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer7CountDays
{
    class Program
    {
        /* 
        Задача №7
        Пользователь вводит количество недель, месяцев, лет и получает количество дней за это время. 
        Считать, что в месяце 30 дней.
        */
        static void Main(string[] args)
        {
            int weeks = 0, months = 0, years = 0, sum = 0;

            Console.WriteLine("Уведіть к-ть тижнів");
            weeks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Уведіть к-ть місяців");
            months = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Уведіть к-ть років");
            years = Convert.ToInt32(Console.ReadLine());

            sum = (weeks * 7) + (months * 30) + (years * 365);

            Console.WriteLine("К-ть днів за цей час = {0}", sum);

            Console.ReadKey();
        }
    }
}
