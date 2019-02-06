using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppHandler
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC выдкритий");
        }

        public override void Create()
        {
            Console.WriteLine("DOC створений");
        }

        public override void Chenge()
        {
            Console.WriteLine("DOC змінений");
        }

        public override void Save()
        {
            Console.WriteLine("DOC збережений");
        }
    }
}
