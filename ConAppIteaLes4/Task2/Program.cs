using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            Console.WriteLine("Уведіть висоту прямокутного трикутника:");
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
