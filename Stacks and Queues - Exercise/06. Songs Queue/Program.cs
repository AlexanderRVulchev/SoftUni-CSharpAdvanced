//Write a program that keeps track of a song's queue.
//The first song that is put in the queue, should be the first that gets played.
//A song cannot be added if it is currently in the queue.
//You will be given a sequence of songs, separated by a comma and a single space.
//After that, you will be given commands until there are no songs enqueued.
//When there are no more songs in the queue print "No more songs!" and stop the program.
//The possible commands are:
//•	"Play" - plays a song(removes it from the queue)
//•	"Add {song}" - adds the song to the queue if it isn’t contained already,
//otherwise print "{song} is already contained!"
//•	"Show" - prints all songs in the queue separated by a comma and a white space
//(start from the first song in the queue to the last)
//Input
//•	On the first line, you will be given a sequence of strings, separated by a comma and a white space
//•	On the next lines, you will be given commands until there are no songs in the queue
//Output
//•	While receiving the commands, print the proper messages described above
//•	After the command "Show", print the songs from the first to the last


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        string[] initialSongs = Console.ReadLine().Split(", ").ToArray();
        Queue<string> playlist = new Queue<string>(initialSongs);
                
        while (playlist.Count > 0)
        {
            string input = Console.ReadLine();
            if (input == "Play")
                playlist.Dequeue();
            else if (input.Split().First() == "Add")
            {
                string newSong = string.Join(" ", input.Split().Skip(1));
                if (playlist.Contains(newSong))
                    Console.WriteLine($"{newSong} is already contained!");
                else
                    playlist.Enqueue(newSong);
            }
            else if (input == "Show")
                Console.WriteLine(String.Join(", ", playlist));
        }
        Console.WriteLine("No more songs!");
    }
}