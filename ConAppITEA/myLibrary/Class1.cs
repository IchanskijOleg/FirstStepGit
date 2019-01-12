using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class User
    {
        public string Name { get; set; }
        public User(string name)
        {
            Name = name;
        }
        public void PrintName()
        {
            Console.WriteLine("username = {0}", Name);

        }
    }
}
