//There is a party in SoftUni.
//Many guests are invited and there are two types of them: VIP and Regular.
//When a guest comes, check if he/she exists in any of the two reservation lists.
//All reservation numbers will be with the length of 8 chars.
//All VIP numbers start with a digit.
//First, you will be receiving the reservation numbers of the guests.
//You can also receive 2 possible commands:
//•	"PARTY" – After this command, you will begin receiving the reservation numbers of the people,
//who came to the party.
//•	"END" – The party is over and you have to stop the program and print the appropriate output.
//In the end, print the count of the guests who didn't come to the party,
//and afterward, print their reservation numbers. the VIP guests must be first.


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> vipGuests = new HashSet<string>();
        HashSet<string> regularGuests = new HashSet<string>();
        string input;
        while ((input = Console.ReadLine()) != "PARTY")
        {
            if (char.IsDigit(input[0])) vipGuests.Add(input);
            else regularGuests.Add(input);
        }
        while ((input = Console.ReadLine()) != "END")
        {
            vipGuests.Remove(input);
            regularGuests.Remove(input);
        }
        Console.WriteLine(vipGuests.Count + regularGuests.Count);

        if (vipGuests.Count > 0)        
            Console.WriteLine(String.Join("\n", vipGuests));
        
        if (regularGuests.Count > 0)
            Console.WriteLine(String.Join("\n", regularGuests));
    }
}