using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppIteaLes8
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Почалася грати музика");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Музика на Паузі");
        }
 
        void IPlayable.Stop()
        {
            Console.WriteLine("Музика Стоп");
        }

        public void Record()
        {
            Console.WriteLine("Почався запис музики");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Запис музики на паузі");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Стоп запис музики");
        }
    }
}
