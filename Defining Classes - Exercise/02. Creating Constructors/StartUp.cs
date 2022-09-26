//Add 3 constructors to the Person class from the last task.
//Use constructor chaining to reuse code:
//•	The first should take no arguments and produce a person
//with the name "No name" and age = 1. 
//•	The second should accept only an integer number for the age
//and produce a person with the name "No name" and age equal to the passed parameter.
//•	The third one should accept a string for the name and an integer for the age
//and should produce a person with the given name and age.


using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person john = new Person("John", 22);
            Console.WriteLine(john.Name);
            Console.WriteLine(john.Age);
        }
    }
}
