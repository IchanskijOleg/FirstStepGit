using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppHandler
{
    /*
    Создайте класс AbstractHandler. 
    В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
    Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler. 
    Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, 
    создания, редактирования, сохранения определенного формата документа.
    */
    class Program
    {
        /*public AbstractHandler UpCast(AbstractHandler clas)
        {
            return clas;
        }*/

        static void Main(string[] args)
        {
            string docType;  
            AbstractHandler handler;

            Console.WriteLine("Уведыть тип документу");
            docType = Console.ReadLine();

            if (docType == "doc")
            {
                handler = new DOCHandler();
            }
            else if (docType == "xml")
            {
                handler = new XMLHandler();
            }
            else // docType == "txt"
            {
                handler = new TXTHandler();
            };

            handler.Create();
            handler.Open();
            handler.Chenge();
            handler.Save();

            Console.ReadKey();
        }
    }
}
