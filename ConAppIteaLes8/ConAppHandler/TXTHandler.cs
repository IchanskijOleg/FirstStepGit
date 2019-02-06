using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppHandler
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT выдкритий");
        }

        public override void Create()
        {
            Console.WriteLine("TXT створений");
        }

        public override void Chenge()
        {
            Console.WriteLine("TXT змінений");
        }

        public override void Save()
        {
            Console.WriteLine("TXT збережений");
        }
    }
}
