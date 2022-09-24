//Ivan’s parents are on a vacation for the holidays and he is planning an epic party at home.
//Unfortunately, his organizational skills are next to non-existent,
//so you are given the task to help him with the reservations.
//On the first line, you receive a list of all the people that are coming.
//On the next lines, until you get the "Party!" command,
//you may be asked to double or remove all the people that apply to the given criteria.
//There are three different criteria: 
//•	Everyone that has his name starting with a given string
//•	Everyone that has a name ending with a given string
//•	Everyone that has a name with a given length.
//Finally, print all the guests who are going to the party separated by ", "
//and then add the ending "are going to the party!".
//If no guests are going to the party print "Nobody is going to the party!". 


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> names = Console.ReadLine().Split().ToList();
        names = ProcessCommands(Console.ReadLine(), names);
        PrintResult(names);
    }

    static List<string> ProcessCommands(string input, List<string> names)
    {
        if (input == "Party!") return names;

        string[] tokens = input.Split();
        string action = tokens[0];
        string condition = tokens[1];
        string value = tokens[2];

        Predicate<string> checker = PredicateBuilder(condition, value);
        Func<List<string>, List<string>> executeCommand = FunctionBuilder(action, checker);
        names = executeCommand(names);

        return ProcessCommands(Console.ReadLine(), names); // Recursion
    }

    static Predicate<string> PredicateBuilder(string condition, string value)
    {
        switch (condition)
        {
            case "StartsWith":
                return x => x.StartsWith(value);
            case "EndsWith":
                return x => x.EndsWith(value);
            case "Length":
                return x => x.Length == int.Parse(value);
            default: return x => x == null;
        }
    }

    static Func<List<string>, List<string>> FunctionBuilder(string action, Predicate<string> checker)
    {
        switch (action)
        {
            case "Double":
                return x =>
                {
                    List<string> newList = new List<string>();
                    foreach (string item in x)
                    {
                        newList.Add(item);
                        if (checker(item))
                        {
                            newList.Add(item);
                        }
                    }
                    return newList;
                };

            case "Remove":
                return x => x.Where(x => !checker(x)).ToList();
            default: return x => x = null;
        }
    }

    static void PrintResult(List<string> names)
    {
        Action<List<string>> print =
            x => Console.WriteLine(string.Join(", ", x) + " are going to the party!");

        if (names.Count > 0)
            print(names);
        else
            Console.WriteLine("Nobody is going to the party!");
    }
}