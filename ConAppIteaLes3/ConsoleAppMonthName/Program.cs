using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMonthName
{
    class Program
    {
        static void Main(string[] args)
        {
            string month, monthName, monthS;

            Console.WriteLine("Уведіть номер місяця");
            month = Console.ReadLine();
            string[] mName = new[] { "Січень", "Лютий", "Березень", "Квітень", "Травень", "Червень", "Липень", "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень" };

            // назва місяця
            switch (month)
            {
                case "1":
                    monthName = "Січень";
                    break;
                case "2":
                    monthName = "Лютий";
                    break;
                case "3":
                    monthName = "Березень";
                    break;
                case "4":
                    monthName = "Квітень";
                    break;
                case "5":
                    monthName = "Травень";
                    break;
                case "6":
                    monthName = "Червень";
                    break;
                case "7":
                    monthName = "Липень";
                    break;
                case "8":
                    monthName = "Серпень";
                    break;
                case "9":
                    monthName = "Вересень";
                    break;
                case "10":
                    monthName = "Жовтень";
                    break;
                case "11":
                    monthName = "Листопад";
                    break;
                case "12":
                    monthName = "Грудень";
                    break;
                default:
                    monthName = "Такого місяця немає";
                    break;
            }
            // пора року
            switch (month)
            {
                case "12":
                case "1":
                case "2":
                    monthS = "Зима";
                    break;
                case "3":
                case "4":
                case "5":
                    monthS = "Весна";
                    break;
                case "6":
                case "7":
                case "8":
                    monthS = "Літо";
                    break;
                case "9":
                case "10":
                case "11":
                    monthS = "Осінь";
                    break;
                default:
                    monthS = "Такого місяця немає";
                    break;
            }
            Console.WriteLine(monthName);
            Console.WriteLine(monthS);

            int i = Convert.ToInt32(month);


            Console.ReadKey();
        }
    }
}
