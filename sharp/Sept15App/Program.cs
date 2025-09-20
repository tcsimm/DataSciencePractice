using System;

class Person
{
    public string Name;
    public int Age;

    // constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Person object created");
    }
}

class Program
{
    static void Main()
    {
        // when you create a new person, the constructor runs automatically
        Person p1 = new Person("Thomas", 25);
        Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}");
    }
}