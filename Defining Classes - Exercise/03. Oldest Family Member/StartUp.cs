//Use your Person class from the previous tasks. Create a class Family.
//The class should have a list of people, a method for adding members -
//void AddMember(Person member), and a method returning
//the oldest family member – Person GetOldestMember().
//Write a program that reads the names and ages of N people and adds them to the family.
//Then print the name and age of the oldest member. 


using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Family family = new Family();
            int numberOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] nameAndAge = Console.ReadLine().Split();
                string name = nameAndAge[0];
                int age = int.Parse(nameAndAge[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }
            Person oldestMember = family.GetOldestMember();
            Console.WriteLine(oldestMember);
        }
    }
}
