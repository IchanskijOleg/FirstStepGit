using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethods
{
    class Program : Object
    {
        /// <summary>
        /// Факторіал числа через рекурсію
        /// </summary>
        /// <param name="num">ціле позитивне число</param>
        /// <returns>число</returns>
        static int Factorial_recurs(int num)
        {
            int fact = 1;
            if (num == 0)
            {
                return 1;
            }
            else
            {
                fact = num * Factorial_recurs(num - 1);
            }


            return fact;
        }

        /// <summary>
        /// Вивід повідомлення на екран
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        static void Function(string b, string a = "")
        {
            Console.WriteLine(a + b);
        }

        /// <summary>
        /// Перегрузка метода класу Object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + "OLEG";
        }

        /// <summary>
        /// Найбільший спільний дільник
        /// </summary>
        /// <param name="a">Число a</param>
        /// <param name="b">Число b</param>
        /// <returns></returns>
        static int GetNSD(int a, int b)
        {
            int res = 1;

            for (int k = Math.Min(a, b); k > 0; k--)
            {
                if (a % k != 0)
                {
                    continue;
                }
                if (b % k != 0)
                {
                    continue;
                }
                res = k;
                break;
            }

            return res;
        }

        /// <summary>
        /// Вивід елементів масиву
        /// </summary>
        /// <param name="array">Масив цілих чисел</param>
        static void PrintArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// Вивід двумірного масиву на екран
        /// </summary>
        /// <param name="array">масив цілих чисел</param>
        static void PrintTwoArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Выполняет конвертирование валют
        /// </summary>
        /// <param name="val">сумму денег в определенной валюте</param>
        /// <param name="curr">курс для конвертации в другую валюту</param>
        /// <returns>сконвертована сума</returns>
        public static int CurrencyConverter(int val, int curr)
        {
            int res = val * curr;
            return res;
        }

        public static void GetPropNumber(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("{0} - положительное число", num);
            }
            else
            {
                Console.WriteLine("{0} - отрицательное число", num);
            }

            int[] arr = new int[5] { 2, 5, 3, 6, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (num % arr[i] == 0)
                {
                    Console.WriteLine("{0} ділиться націло на {1}", num, arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Function("Hello ", "Oleg!");
            Function(b: "df");
            Console.WriteLine(new string('-', 40));

            Console.WriteLine(Factorial_recurs(4));

            int a = 18, b = 45;
            Console.WriteLine("НСД({0},{1}) = {2}", a, b, GetNSD(a, b));

            Program p = new Program();
            Console.WriteLine(p.GetHashCode());
            Program p1 = p;
            Console.WriteLine(p1.GetHashCode());

            Program p2 = new Program();
            Console.WriteLine(p2.ToString());

            //виведемо елементи масиву
            Console.WriteLine(new string('-', 50));
            PrintArray(1, 2, 3, 5, 8, 9);

            //виведемо елементи двомірного масиву
            Console.WriteLine(new string('-', 50));
            int[,] arr = //new int[3, 4] можна розкоментувати різниці
            {
                {1,2,3,33},
                {4,5,6,66},
                {7,8,9,99}
             };
            PrintTwoArray(arr);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Сумма денег в определенной валюте");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("курс для конвертации в другую валюту");
            int curr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} едениц по курсу {1} = {2}", val, curr, CurrencyConverter(val, curr));

            GetPropNumber(8);

            Console.ReadKey();
        }
    }
}
