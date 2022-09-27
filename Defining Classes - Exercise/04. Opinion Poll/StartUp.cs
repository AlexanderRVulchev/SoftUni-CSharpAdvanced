//Using the Person class, write a program that reads from the console
//N lines of personal information and then prints all people,
//whose age is more than 30 years, sorted in alphabetical order.

using System;
using System.Linq;

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
            
            Person[] filteredPeople = family.People
                .FindAll(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToArray();

            foreach (Person person in filteredPeople)
                Console.WriteLine(person);
        }
    }
}
