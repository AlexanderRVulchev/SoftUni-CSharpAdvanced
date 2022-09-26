//Define a class Person with private fields for name and age and public properties Name and Age.

using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person peter = new Person();
            peter.Name = "Peter";
            peter.Age = 20;
            Console.WriteLine(peter.Name);
            Console.WriteLine(peter.Age);
        }
    }
}
