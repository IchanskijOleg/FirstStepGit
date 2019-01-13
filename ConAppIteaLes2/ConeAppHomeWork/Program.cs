using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConeAppHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;

            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Математические вычисления и класс Math");
            Console.WriteLine(new string('-', 40));

            //Abs(double value): возвращает абсолютное значение для аргумента value
            result = Math.Abs(-9.9); // 9.9
            Console.WriteLine("Math.Abs(-9.9) = {0}", result);

            //Ceiling(double value): возвращает наименьшее целое число с плавающей точкой, которое не меньше value
            result = Math.Ceiling(5.1); // 6
            Console.WriteLine("Math.Ceiling(5.1) = {0}", result);

            //Floor(decimal d): возвращает наибольшее целое число, которое не больше d
            result = Math.Floor(5.1); // 5
            Console.WriteLine("Math.Floor(5.1) = {0}", result);

            //Max(double a, double b): возвращает максимальное число из a и b
            result = Math.Max(9, 1); // 9
            Console.WriteLine("Math.Max(9, 1) = {0}", result);

            //Min(double a, double b): возвращает минимальное число из a и b
            result = Math.Min(9, 1); // 1
            Console.WriteLine("Math.Min(9, 1) = {0}", result);

            //Pow(double a, double b): возвращает число a, возведенное в степень b
            result = Math.Pow(4, 2); // 16
            Console.WriteLine("Math.Pow(4, 2) = {0}", result);

            //Sqrt(double a): возвращает корень квадратный от числа а
            result = Math.Sqrt(16); // 4
            Console.WriteLine("Math.Sqrt(16) = {0}", result);

            //Round(double d): возвращает число d, округленное до ближайшего целого числа
            result = Math.Round(4.516); // 5
            Console.WriteLine("Math.Round(4.516) = {0}", result);

            //Truncate(double value): отбрасывает дробную часть числа value, возвращаяя лишь целое значние
            result = Math.Truncate(4.516); // 4
            Console.WriteLine("Math.Truncate(4.516) = {0}", result);

            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Преобразование типов и класс Convert");
            Console.WriteLine(new string('-', 40));

            int n = Convert.ToInt32("78");
            bool b = true;
            double d = Convert.ToDouble(b);
            Console.WriteLine($"int n={n}(string)  double d={d}(bool)");

            int iParse = int.Parse("10");
            Console.WriteLine("int.Parse(\"10\") = {0}", iParse);
            double dParse = double.Parse("23,56");
            Console.WriteLine("double.Parse(\"23, 56\") = {0}", dParse);
            decimal deParse = decimal.Parse("12,45");
            Console.WriteLine("decimal.Parse(\"12, 45\") = {0}", deParse);
            byte bParse = byte.Parse("4");
            Console.WriteLine("byte.Parse(\"4\") = {0}", bParse);

            Console.ReadKey();
        }
    }
}
