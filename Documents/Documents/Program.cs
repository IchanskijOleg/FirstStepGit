using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    class Program
    {
        /*
        В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. 
        Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса), 
        если пользователь ввел номера ключа доступа pro и exp, то должен создаться экземпляр соответствующей версии класса, 
        приведенный к базовому – DocumentWorker. 

        */
        static void Main(string[] args)
        {
            const string keyPro = "pro";
            const string keyExp = "exp";
            string userKey;

            Console.WriteLine("Введите ключ");
            userKey = Console.ReadLine();

            DocumentWorker doc;
            if (userKey == keyPro)
            {
                ProDocumentWorker docPro = new ProDocumentWorker();
                doc = (DocumentWorker)docPro;
            }
            else if (userKey == keyExp)
            {
                //ExpertDocumentWorker docExp = new ExpertDocumentWorker();
                //doc = (DocumentWorker)docExp;
                doc = new ExpertDocumentWorker();
            }
            else
            {
                doc = new DocumentWorker();
            }

            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            Console.ReadKey();
        }
    }
}
