using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppIteaLes7
{
    class Program
    {
        /* 
            создать масив обектов даного класа 
            вивести список покупців в алфавітному порядку
            вивести список покупців в яких номер кредитки знаходиться в заданому діапазоні  */

        public static void PrintCustInCard(int leftCard, int rigthCard, Customer c)
        {
            if (c.CreditCart <= rigthCard)
            {
                c.PrintCast();
            }
        }

        static void Main(string[] args)
        {
            Customer c1 = new Customer("Ichanskij", "Oleg", "Oleksiyovich", 1, 99999);
            Customer c2 = new Customer("Buts", "Ksiniya", "Mukolaevna", 2, 99999);
            Customer c3 = new Customer("Ichanskij", "Ivan", "Olehovich", 3, 99999);


            Customer[] arrayCust = new Customer[] { c1, c2, c3 };

            for (int i = 0; i < arrayCust.Length; i++)
            {
                PrintCustInCard(1, 2, arrayCust[i]);
            }

            Console.ReadKey();
        }
    }
}
