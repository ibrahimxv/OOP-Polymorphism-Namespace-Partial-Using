using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism3
{
    internal class Student
    {
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public int Age { get; set; }

        public Student(string fullname, string groupno, int age)
        {
             FullName = fullname;
             GroupNo = groupno;
             Age = age;
        }
        public Student(string groupno)
        {
            if (char.IsUpper(GroupNo[0]) && GroupNo.Length == 4 &&
                char.IsDigit(GroupNo[1]) && char.IsDigit(GroupNo[2]) && char.IsDigit(GroupNo[3]))
            {
                GroupNo = groupno;
            }
        }     
        public Student(string fullname, int age) 
        {
            string[] parts = fullname.Split(' ');

            if (parts.Length == 2 )
            {
                FullName = fullname;
            }
            else
            {
                Console.WriteLine("Fullname duzgun deyil!");
            }
            Age = age;
        }
    }

}
