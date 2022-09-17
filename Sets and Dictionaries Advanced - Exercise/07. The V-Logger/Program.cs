//Create a program that keeps the information about vloggers and their followers.
//The input will come as a sequence of strings, where each string will represent a valid command.
//The commands will be presented in the following format:
//•	"{vloggername}" joined The V-Logger – keep the vlogger in your records.
//o	Vloggernames consist of only one word.
//o	If the given vloggername already exists, ignore that command.

//•	"{vloggername} followed {vloggername}" – The first vlogger followed the second vlogger.
//o	If any of the given vlogernames does not exist in your collection, ignore that command.
//o	Vlogger cannot follow himself
//o	Vloggers cannot follow someone he is already a follower of

//•	"Statistics" - Upon receiving this command, you have to print a statistic about the vloggers.
//Each vlogger has a unique vloggername.
//Vloggers can follow other vloggers and a vlogger can follow as many other vloggers as he wants,
//but he cannot follow himself or follow someone he is already a follower of.
//You need to print the total count of vloggers in your collection.
//Then you have to print the most famous vlogger – the one with the most followers, with his followers.
//If more than one vloggers have the same number of followers, print the one following fewer people,
//and his followers should be printed in lexicographical order
//(in case the vlogger has no followers, print just the first line, which is described below).
//Lastly, print the rest vloggers, ordered by the count of followers in descending order,
//then by the number of vloggers he follows in ascending order.
//The whole output must be in the following format:
//"The V-Logger has a total of {registered vloggers} vloggers in its logs.
//1. { mostFamousVlogger} : { followers}
//followers, { followings}
//following
//*  { follower1}
//*  { follower2} … 
//{ No}. { vlogger} : { followers}
//followers, { followings}
//following
//{ No}. { vlogger} : { followers}
//followers, { followings}
//following…"
//Input
//•	The input will come in the format described above.
//Output
//•	On the first line, print the total count of vloggers in the format described above.
//•	On the second line, print the most famous vlogger in the format described above.
//•	On the next lines, print all of the rest vloggers in the format described above.


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var following = new Dictionary<string, SortedSet<string>>();
        var followedBy = new Dictionary<string, SortedSet<string>>();

        string input;
        while ((input = Console.ReadLine()) != "Statistics")
        {
            string[] tokens = input.Split();
            string firstName = tokens[0];
            string action = tokens[1];
            string secondName = tokens[2];
            if (action == "joined" && 
                !following.ContainsKey(firstName))
            {
                following.Add(firstName, new SortedSet<string>());
                followedBy.Add(firstName, new SortedSet<string>());
            }
            else if (action == "followed" && 
                     following.ContainsKey(firstName) && 
                     followedBy.ContainsKey(secondName) &&
                     firstName != secondName)
            {
                following[firstName].Add(secondName);
                followedBy[secondName].Add(firstName);
            }
        }

        Console.WriteLine($"The V-Logger has a total of {following.Count} vloggers in its logs.");
        int ranking = 1;
        foreach (var vlogger in followedBy
            .OrderByDescending(x => x.Value.Count)
            .ThenBy(x => following[x.Key].Count))
        {
            Console.WriteLine($"{ranking}. {vlogger.Key} : {vlogger.Value.Count} followers, {following[vlogger.Key].Count} following");
            if (ranking == 1)
            {
                Console.WriteLine(String.Join("\n", vlogger.Value.Select(x => $"*  {x}")));
            }
            ranking++;
        }
    }
}