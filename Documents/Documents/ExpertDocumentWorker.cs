using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    /*Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker. 
    Переопределите соответствующий метод. 
    При вызове данного метода необходимо выводить на экран "Документ сохранен в новом формате". 
    */
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
