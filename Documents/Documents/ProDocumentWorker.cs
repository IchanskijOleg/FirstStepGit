using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    /*
    Создайте производный класс ProDocumentWorker. 
    Переопределите соответствующие методы, при переопределении методов выводите следующие строки: 
        "Документ отредактирован", 
        "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт". 
    */
    class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument() // можна було і не переопреділять - але залишив так для наглядності
        {
            base.OpenDocument();
        }
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}
