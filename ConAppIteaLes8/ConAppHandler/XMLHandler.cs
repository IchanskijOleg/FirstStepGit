using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppHandler
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML выдкритий");
        }

        public override void Create()
        {
            Console.WriteLine("XML створений");
        }

        public override void Chenge()
        {
            Console.WriteLine("XML змінений");
        }

        public override void Save()
        {
            Console.WriteLine("XML збережений");
        }
    }
}
