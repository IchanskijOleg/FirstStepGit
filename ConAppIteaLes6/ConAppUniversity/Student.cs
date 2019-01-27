using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppUniversity
{
    class Student
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string GroupId { get; }
        public int[] Rating { get; }

        public Student(string lastName, string firstName, string groupId, params int[] rating)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.GroupId = groupId;
            this.Rating = rating;
        }
        public Student(string lastName, string firstName, string groupId, string rating)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.GroupId = groupId;

            string[] nums_strings = rating.Split();
            int[] nums = new int[nums_strings.Length];
            for (int i = 0; i < nums_strings.Length; i++)
            {
                nums[i] = Convert.ToInt32(nums_strings[i]);
            }

            this.Rating = nums;
        }
        /// <summary>
        /// Пошук середньої оцінки студента
        /// </summary>
        /// <returns>середня оцінка</returns>
        public int GetAverageRating()
        {
            double sum = 0;
            int res;
            for (int i = 0; i < Rating.Length; i++)
            {
                sum += Rating[i];
            }
            res = (int)Math.Round(sum / Rating.Length);
            return res;
        }
    }
}
