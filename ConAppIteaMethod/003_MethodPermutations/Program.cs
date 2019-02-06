using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_MethodPermutations
{
    class Program
    {
        /*
        ЗАДАЧА №3
        Дана строка, состоящая из N попарно различных символов. 
        Требуется вывести все перестановки символов данной строки.
        */
        static void Main(string[] args)
        {
            string str = "1 2 3";
            string[] s = str.Split();
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i].ToString());
            }

            Console.ReadKey();
        }
    }
}
