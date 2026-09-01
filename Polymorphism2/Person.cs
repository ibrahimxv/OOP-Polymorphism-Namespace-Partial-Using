using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism2;

public class Person 
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public int Age { get; set; }

    public Person(string name, string surname)
    {
         Name = name;
        SurName = surname;
    }


    public Person(string name, string surname, int age)
    {
        if (name.Length >= 3 && name.Length <= 30 &&
            surname.Length >= 3 && surname.Length <= 35 &&
            char.IsUpper(name[0]) && char.IsUpper(surname[0]))
        {
            Name = name;
            SurName = surname;
            Age = age;  
        }
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Surname: {SurName}, Age: {Age}");
    }
}
