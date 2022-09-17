//Create a program that ranks candidate-interns,
//depending on the points from the interview tasks and their exam results in SoftUni.
//You will receive some lines of input in the format "{contest}:{password for contest}"
//until you receive "end of contests". Save that data because you will need it later.
//After that you will receive another type of inputs in the format
//"{contest}=>{password}=>{username}=>{points}" until you receive "end of submissions".
//Here is what you need to do:
//•	Check if the contest is valid(if you received it in the first type of input)
//•	Check if the password is correct for the given contest
//•	Save the user with the contest they take part in (a user can take part in many contests)
//and the points the user has in the given contest. If you receive the same contest and the same user,
//update the points only if the new ones are more than the older ones.
//At the end you have to print the info for the user with the most points in the format:
//"Best candidate is {user} with total {total points} points.".
//After that print all students ordered by their names.
//For each user, print each contest with the points in descending order in the following format:
//"{user1 name}
//#  {contest1} -> {points}
//#  {contest2} -> {points}
//{ user2 name}
//…"
//Input
//•	You will be receiving strings in the formats described above,
//until the appropriate commands, also described above, are given.
//Output
//•	On the first line print, the best user in the format described above. 
//•	On the next lines print all students ordered as mentioned above in format.


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var contestsDict = ReadContestAndPasswordData();
        var studentsDict = GetStudentsScores(contestsDict);
        PrintResults(studentsDict);
    }

    static Dictionary<string, string> ReadContestAndPasswordData()
    {
        var contestsDict = new Dictionary<string, string>();
        string input;
        while ((input = Console.ReadLine()) != "end of contests")
        {
            string contest = input.Split(":").First();
            string password = input.Split(":").Last();
            contestsDict[contest] = password;
        }
        return contestsDict;
    }

    static SortedDictionary<string, Dictionary<string, int>> GetStudentsScores(Dictionary<string, string> contestsDict)
    {
        var studentsDict = new SortedDictionary<string, Dictionary<string, int>>();
        string input;
        while ((input = Console.ReadLine()) != "end of submissions")
        {
            string[] tokens = input.Split("=>");
            string contest = tokens[0];
            string password = tokens[1];
            string student = tokens[2];
            int points = int.Parse(tokens[3]);
            if (!contestsDict.ContainsKey(contest) || contestsDict[contest] != password)
            {
                continue;
            }

            if (!studentsDict.ContainsKey(student))
                studentsDict.Add(student, new Dictionary<string, int>());
            if (!studentsDict[student].ContainsKey(contest))
                studentsDict[student].Add(contest, 0);
            if (studentsDict[student][contest] < points)
                studentsDict[student][contest] = points;
        }
        return studentsDict;
    }

    static void PrintResults(SortedDictionary<string, Dictionary<string, int>> studentsDict)
    {
        string bestCandidate = studentsDict
            .OrderByDescending(x => x.Value.Values.Sum())
            .Select(x => x.Key)
            .First();
        int maxPoints = studentsDict[bestCandidate].Values
            .Sum();
        Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");
        Console.WriteLine("Ranking:");

        foreach (var student in studentsDict)
        {
            Console.WriteLine(student.Key);
            foreach (var contest in student.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
            }
        }
    }
}