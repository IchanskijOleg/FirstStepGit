using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMyData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;

            string firstName, lastName, birthdate, age; 
            Console.WriteLine("Введіть імя");
            firstName = Console.ReadLine();

            Console.WriteLine("Введіть Прізвище"); 
            lastName = Console.ReadLine();

            Console.WriteLine("дату народження");  
            birthdate = Console.ReadLine();

            Console.WriteLine("вік");
            age = Console.ReadLine();

            Console.WriteLine("Вас звати {1} {0}. Ви народилися {2} і вам років {3}.", firstName, lastName, birthdate, age);

            Console.ReadLine();
        }
    }
}
