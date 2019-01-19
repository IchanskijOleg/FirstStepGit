using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Уведіть ширину примокутника:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Уведіть висоту примокутника:");
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= b; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
