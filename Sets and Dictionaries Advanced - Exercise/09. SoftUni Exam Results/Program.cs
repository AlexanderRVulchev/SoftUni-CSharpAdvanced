//Judge statistics on the last Programing Fundamentals exam was not working correctly,
//so you have the task to take all the submissions and analyze them properly.
//You should collect all the submissions and print the final results and statistics about
//each language that the participants submitted their solutions in.
//You will be receiving lines in the following format: "{username}-{language}-{points}"
//until you receive "exam finished". You should store each username and his submissions and points. 
//You can receive a command to ban a user for cheating in the following format:
//"{username}-banned".In that case, you should remove the user from the contest,
//but preserve his submissions in the total count of submissions for each language.
//After receiving "exam finished" print each of the participants,
//ordered descending by their max points, then by username, in the following format:
//"Results:"
//"{username} | {points}"
//…
//After that print each language, used in the exam,
//ordered descending by total submission count and then by language name, in the following format:
//"Submissions:"
//"{language} – {submissionsCount}"
//…
//Input / Constraints
//Until you receive "exam finished"
//you will be receiving participant submissions in the following format: "{username}-{language}-{points}".
//You can receive a ban command -> "{username}-banned"
//The points of the participant will always be a valid integer in the range [0-100];
//Output
//•	Print the exam results for each participant,
//ordered descending by max points and then by username, in the following format: 
//"Results:"
//"{username} | {points}"
//…
//•	After that print each language, ordered descending by total submissions and then by language name,
//in the following format:
//"Submissions:"
//"{language} – {submissionsCount}"
//…


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var studentDict = new Dictionary<string, int>();
        var languageDict = new Dictionary<string, int>();
        string input;
        while ((input = Console.ReadLine()) != "exam finished")
        {
            string[] tokens = input.Split("-");
            if (tokens[1] == "banned")
            {
                studentDict.Remove(tokens[0]);
                continue;
            }

            string student = tokens[0];
            string language = tokens[1];
            int points = int.Parse(tokens[2]);

            if (!studentDict.ContainsKey(student))
                studentDict.Add(student, 0);
            if (studentDict[student] < points)
                studentDict[student] = points;

            if (!languageDict.ContainsKey(language))
                languageDict.Add(language, 0);
            languageDict[language]++;
        }

        Console.WriteLine("Results:");
        foreach (var student in studentDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{student.Key} | {student.Value}");
        }
        Console.WriteLine("Submissions:");
        foreach (var language in languageDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{language.Key} - {language.Value}");
        }
    }
}