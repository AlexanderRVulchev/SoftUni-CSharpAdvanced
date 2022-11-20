using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Food_Finder
{
    internal class Program
    {
        static void Main()
        {
            var vowels = new Queue<char>(string.Join("", Console.ReadLine().Split()).ToCharArray());
            var consonants = new Stack<char>(string.Join("", Console.ReadLine().Split()).ToCharArray());
            HashSet<string> wordsSet = new HashSet<string>(new string[] { "pear", "flour", "pork", "olive" });
            HashSet<char> usedLetters = new HashSet<char>();
            
            while (consonants.Any())
            {
                usedLetters.Add(consonants.Pop());
                usedLetters.Add(vowels.Peek());
                vowels.Enqueue(vowels.Dequeue());
            }

            List<string> validWords = new List<string>();
            foreach (string word in wordsSet)
            {
                if (string.Join("", word.Intersect(usedLetters)) == word)
                    validWords.Add(word);
            }

            Console.WriteLine($"Words found: {validWords.Count} ");
            Console.WriteLine(string.Join(Environment.NewLine, validWords));
        }
    }
}
