using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDelegate
{
    class Program
    {
        public static void PrintOne()
        {
            Console.WriteLine("PrintOne");
        }
        public static void PrintTwo()
        {
            Console.WriteLine("PrintTwo");
        }

        delegate void Print(); // 1. Объявляем делегат

        static void Main(string[] args)
        {
            Print print; // 2. Создаем переменную делегата
            print = PrintOne; // 3. Присваиваем этой переменной адрес метода
            print += PrintTwo;

            print(); // 4. Вызываем метод
            Console.ReadKey();
        }
    }
}
