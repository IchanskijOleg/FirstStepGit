using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Program
    {
        /*
        Задача №7
        Дано n кирпичей. Вы и компьютер ходите поочередно. за ход можно взять 1, 2 или 3 кирпича. 
        Проиграл тот, кому нечего брать. 
        Реализуйте игру с компьютером. 
        Компьютер ходит случайно (без анализа выигрышной стратегии), 
        однако если у него есть ход, который является последним для его выигрыша, то он его совершает.
        */
        static void Main(string[] args)
        {
            int totalCount = 0;
            int countI = 0, countComp = 0;

            Console.WriteLine("Уведіть число цеглинок:");
            totalCount = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Ваш хід. Візьміть від 1 до 3 цеглин:");
                countI = Convert.ToInt32(Console.ReadLine());
                totalCount -= countI;
                Console.WriteLine("Залишилося {0} цеглин.", totalCount);
                if (totalCount <= 0)
                {
                    Console.WriteLine("Компютер програв");
                    break;
                }

                Random getrandom = new Random();
                countComp = getrandom.Next(1, 3);
                countComp = Math.Min(countComp, totalCount);
                Console.WriteLine("число компютера = {0}",countComp); 
                totalCount -= countComp;
                Console.WriteLine("Залишилося {0} цеглин.", totalCount);
                if (totalCount <= 0)
                {
                    Console.WriteLine("Ви програли");
                    break;
                }
            } while (totalCount >= 0);
            Console.ReadKey();
        }
    }
}
