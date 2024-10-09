﻿class Program
{
    static void Main()
    {
        Person person = new Person();
        person.GetInfo();
        person.DisplayInfo();
    }
}
public class Person
{
    public string Name { get; set; }
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                age = 0;
            }
            else if (value > 120)
            {
                age = 120;
            }
            else
            {
                age = value;
            }
        }
    }


    public void GetInfo()
    {
        Name = "Anna";
        Age = 130;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}



