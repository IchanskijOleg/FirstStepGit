using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppIteaLes8
{

    /*
    Создайте 2 интерфейса IPlayable и IRecodable.
    В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() 
    и void Record() / void Pause() / void Stop() соответственно. 
    Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
    Написать программу, которая выполняет проигрывание и запись.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IPlayable play = (IPlayable)player;
            IRecodable rec = (IRecodable)player;

            player.Play();
            player.Record();

            play.Pause();
            play.Stop();

            rec.Pause();
            rec.Stop();

            Console.ReadKey();
        }
    }
}
