using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism2;

internal class Student : Person 
{
    public int Point { get; set; }

    public Student (string name, string surname, int age, int point)
        : base(name, surname, age)
    {
        if (point >= 0 && point <= 100)
        {
            Point = point;
        }
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Surname: {SurName}, Age: {Age}, Point: {Point}");
    }

}
