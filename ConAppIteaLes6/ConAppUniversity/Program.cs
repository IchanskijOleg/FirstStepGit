using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Уведіть двох студентів");
            string lastName;
            string firstName;
            string groupId;
            string rating;

            Console.WriteLine("Уведіть Прізвище студента");
            lastName = Console.ReadLine();
            Console.WriteLine("Уведіть Імя студента");
            firstName = Console.ReadLine();
            Console.WriteLine("Уведіть групу студента");
            groupId = Console.ReadLine();
            Console.WriteLine("Уведіть середню оцінку студента");
            rating = Console.ReadLine();
            //int[] rat = new int[] { 4, 4, 5 };

            Student student1 = new Student(lastName, firstName, groupId, rating);
            Console.WriteLine(student1.GetAverageRating());

            if (student1.GetAverageRating() >= 4)
            {
                Console.WriteLine("Студент {0} {1} з групи {2} є відмінником", student1.LastName, student1.FirstName, student1.GroupId);
            }
            else
            {
                Console.WriteLine("Студент {0} {1} з групи {2} є двіюшник", student1.LastName, student1.FirstName, student1.GroupId);
            }
            Console.ReadKey();
        }
    }
}
