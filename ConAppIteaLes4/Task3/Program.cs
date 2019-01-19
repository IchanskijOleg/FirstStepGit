using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            Console.WriteLine("Уведіть висоту рівнобедренного трикутника:");
            b = 10;//Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= b; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j < b - i)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('*');
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
