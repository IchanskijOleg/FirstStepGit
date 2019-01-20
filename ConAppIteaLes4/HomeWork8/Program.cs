using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class Program
    {
        /*
        Задача №8
        Компьютер загадывает число от 1 до 100. 
        У пользователя три попытки отгадать. 
        После каждой неудачной попытки компьютер сообщает меньше или больше загаданное число.
        */
        static void Main(string[] args)
        {
            int attempt = 3;
            int numberI = 0, numberComp;
            string writeline;

            Random getrandom = new Random();
            numberComp = getrandom.Next(1, 100);
            //Console.WriteLine(numberComp);
            do
            {
                Console.WriteLine("Вгадайте число:");
                numberI = Convert.ToInt32(Console.ReadLine());

                if (numberComp < numberI)
                {
                    Console.WriteLine("Загадане число менше за ваше {0}", numberI);
                    Console.WriteLine("Залишилося {0} спроб.", --attempt);
                    continue;
                }
                else if (numberComp > numberI)
                {
                    Console.WriteLine("Загадане число більше за ваше {0}", numberI);
                    Console.WriteLine("Залишилося {0} спроб.", --attempt);
                    continue;
                }
            } while (numberComp != numberI && attempt != 0);

            writeline = (numberComp == numberI) ? "Ура ви відгадали." : "Не відгадали. Загадане число було " + numberComp;
            Console.WriteLine(writeline);
            Console.ReadKey();
        }
    }
}
