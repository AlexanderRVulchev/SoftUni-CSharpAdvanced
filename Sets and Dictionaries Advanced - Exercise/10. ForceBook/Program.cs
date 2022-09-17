//The force users are struggling to remember which side is the different forceUsers
//from because they switch them too often.
//So you are tasked to create a web application to manage their profiles.
//You should store an information for every unique forceUser, registered in the application.
//You will receive several input lines in one of the following formats:
//{ forceSide} | { forceUser}
//{ forceUser} -> { forceSide}
//The forceUser and forceSide are strings, containing any character. 
//If you receive forceSide | forceUser, you should check if such forceUser already exists,
//and if not, add him/her to the corresponding side. 
//If you receive a forceUser -> forceSide,
//you should check if there is such a forceUser already and if so, change his/her side.
//If there is no such forceUser, add him/her to the corresponding forceSide,
//treating the command as a newly registered forceUser.
//Then you should print on the console: "{forceUser} joins the {forceSide} side!"
//You should end your program when you receive the command "Lumpawaroo".
//At that point, you should print each force side,
//ordered descending by forceUsers count then ordered by name.
//For each side print the forceUsers, ordered by name.
//In case there are no forceUsers in the side, you shouldn`t print the side information. 
//Input / Constraints
//•	The input comes in the form of commands in one of the formats specified above.
//•	The input ends, when you receive the command "Lumpawaroo".
//Output
//•	As output for each forceSide, ordered descending by forceUsers count,
//then by name, you must print all the forceUsers, ordered by name alphabetically.
//•	The output format is:
//"Side: {forceSide}, Members: {forceUsers.Count}"
//"! {forceUser}"
//"! {forceUser}"
//"! {forceUser}"
//•	In case there are NO forceUsers, don`t print this side. 


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var userSideDict = new Dictionary<string, List<string>>();
        string input;
        while ((input = Console.ReadLine()) != "Lumpawaroo")
        {
            if (input.Contains(" | "))
                AddUserToSide(input, userSideDict);
            else if (input.Contains(" -> "))
                ChangeUserSide(input, userSideDict);
        }
        PrintResult(userSideDict);
    }

    static void AddUserToSide(string input, Dictionary<string, List<string>> userSideDict)
    {
        string side = input.Split(" | ").First();
        string user = input.Split(" | ").Last();
        if (!userSideDict.Any(x => x.Value.Contains(user)))
        {
            if (!userSideDict.ContainsKey(side))
                userSideDict.Add(side, new List<string>());
            userSideDict[side].Add(user);
        }
    }

    static void ChangeUserSide(string input, Dictionary<string, List<string>> userSideDict)
    {
        string user = input.Split(" -> ").First();
        string side = input.Split(" -> ").Last();
        if (userSideDict.Any(x => x.Value.Contains(user)))
        {
            string sideToRemoveFrom = userSideDict.Where(x => x.Value.Contains(user)).First().Key;
            userSideDict[sideToRemoveFrom].Remove(user);
        }
        string modifiedInput = side + " | " + user;
        AddUserToSide(modifiedInput, userSideDict);
        Console.WriteLine($"{user} joins the {side} side!");
    }

    static void PrintResult(Dictionary<string, List<string>> userSideDict)
    {
        var filteredDict = userSideDict
            .Where(x => x.Value.Count > 0)
            .OrderByDescending(x => x.Value.Count)
            .ThenBy(x => x.Key);

        foreach (var side in filteredDict)
        {
            Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
            foreach (var user in side.Value.OrderBy(x => x))
            {
                Console.WriteLine($"! {user}");
            }
        }
    }
}