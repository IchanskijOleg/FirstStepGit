using System;
using myLibrary;

namespace ConAppITEA
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Oleg");
            user.PrintName();

            Console.ReadLine();
        }
    }
}
