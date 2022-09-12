//Create a program, which reads a name of a student and his/her grades
//and adds them to the student record,
//then prints the students' names with their grades and their average grade.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int numberOfEntries = int.Parse(Console.ReadLine());
        var gradesByName = new Dictionary<string, List<decimal>>();
        for (int i = 0; i < numberOfEntries; i++)
        {
            string entry = Console.ReadLine();
            string name = entry.Split().First();
            decimal grade = decimal.Parse(entry.Split().Last());

            if (!gradesByName.ContainsKey(name))
                gradesByName.Add(name, new List<decimal>());
            gradesByName[name].Add(grade);
        }
        foreach (var name in gradesByName)
        {
            Console.WriteLine($"{name.Key:f2} -> "
                + String.Join(" ", name.Value.Select(x => $"{x:f2}"))
                + $" (avg: {name.Value.Average():f2})");
        }
    }
}