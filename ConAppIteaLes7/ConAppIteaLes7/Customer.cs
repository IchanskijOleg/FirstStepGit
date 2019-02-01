using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppIteaLes7
{
    /* клас покупатель з полями 
            пірізвище
            імя
            побатькові 
            адреса
            номер кредитки
            номер банк рахунку
            в класі має бути конструктор
            свойства для кожного поля
            врахувать що поля не мають бути пустими в свойствах
            */
    class Customer
    {
        private string lastName;
        private string firstName;
        private string midleName;
        private int creditCart;
        private int bankNum;

        public string LastName
        {
            get { return lastName; }
            set { lastName = (value == null) ? "lastName" : value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = (value == null) ? "firstName" : value; }
        }
        public string MidleName
        {
            get { return midleName; }
            set { midleName = (value == null) ? "midleName" : value; }
        }
        public int CreditCart
        {
            get { return creditCart; }
            set { creditCart = (value == 0) ? 100 : value; }
        }
        public int BankNum
        {
            get { return bankNum; }
            set { bankNum = (value == 0) ? 999 : value; }
        }

        public Customer(string lastName, string firstName, string midleName, int creditCart, int bankNum)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.MidleName = midleName;
            this.CreditCart = creditCart;
            this.BankNum = bankNum;
        }

        public void PrintCast()
        {
            Console.WriteLine("Покупець: {0} {1} {2} {3} {4}", lastName, firstName, midleName, creditCart, bankNum);
        }

    }
}
