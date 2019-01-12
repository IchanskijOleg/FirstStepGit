using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppClass
{
    /* Создать класс с именем Address. 
       В теле класса требуется создать поля: index, country, city, street, house, apartment.  
       Для каждого поля, создать свойство с двумя методами доступа.  
       Создать экземпляр класса Address.  
       В поля экземпляра записать информацию о почтовом адресе.  
       Выведите на экран значения полей, описывающих адрес */
    class Address
    {
        //Поля
        private string index, country;//, city, street, house, apartment;
        //Свойства
        public string Index
        {
            set { index = value; }
            get { return index; }
        }
        public string Country
        {
            set { country = value; }
            get { return country; }
        }
        public string City { set; get; }
        public string Street { set; get; }
        public string House { set; get; }
        public string Apartment { set; get; }
        //Конструктор класса
        /*public Address()
        {
            index = "-";
            country = "-";
            city = "-";
            street = "-";
            house = "-";
            apartment = "-";
        }*/

    }
}
