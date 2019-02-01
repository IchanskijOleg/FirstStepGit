using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    /*
    В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument(). 
    В тело каждого из методов добавьте вывод на экран соответствующих строк: 
        "Документ открыт", 
        "Редактирование документа доступно в версии Про", 
        "Сохранение документа доступно в версии Про". 
    */
    class DocumentWorker
    {
        /// <summary>
        /// Відкрити документ
        /// </summary>
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        /// <summary>
        /// Редагувати документ
        /// </summary>
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        /// <summary>
        /// Зберегти документ
        /// </summary>
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}
