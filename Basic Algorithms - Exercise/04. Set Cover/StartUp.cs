//Create a program that finds the smallest subset of sets, which contains all elements from a given sequence. 
//In the Set Cover Problem, we are given two sets - a set of sets (we’ll call it sets) and a universe (a sequence)
//. The sets contain all elements from the universe and no others; however, some elements are repeated.
//The task is to find the smallest subset of sets that contains all elements in the universe.


namespace SetCover
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    class Set
    {
        public int[] SetNumbers { get; set; }
        public int ValidMatches { get; set; }

        public Set(int[] set)
        {
            this.SetNumbers = set;
            this.ValidMatches = 0;
        }

        public void CalculateValidMatches(List<int[]> resultSets)
        {
            this.ValidMatches = 0;
            foreach (int setNum in this.SetNumbers)
            {
                bool isValid = true;
                foreach (int[] resultArray in resultSets)
                    if (resultArray.Contains(setNum))
                        isValid = false;
                if (isValid) this.ValidMatches++;
            }            
        }
    }

    class StartUp
    {
        static void Main()
        {
            IList<int> universe = Console.ReadLine().Split(", ").Select(int.Parse).ToImmutableList();
            int numberOfLines = int.Parse(Console.ReadLine());
            List<int[]> sets = new List<int[]>();
            for (int i = 0; i < numberOfLines; i++)
            {
                sets.Add(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            }
            List<int[]> result = ChooseSets(sets, universe);

            Console.WriteLine($"Sets to take ({result.Count}):");
            foreach (var intArray in result)
            {
                Console.WriteLine("{ " + String.Join(", ", intArray) + " }");
            }
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            List<int[]> resultSets = new List<int[]>();
            List<Set> allSets = new List<Set>();
            foreach (var set in sets)
                allSets.Add(new Set(set));

            for (int i = 0; i < sets.Count; i++)
            {
                allSets.ForEach(x => x.CalculateValidMatches(resultSets));
                Set bestSet = allSets.OrderByDescending(x => x.ValidMatches).First();
                if (bestSet.ValidMatches != 0)
                {
                    resultSets.Add(bestSet.SetNumbers);
                    allSets.Remove(bestSet);
                }
            }
            return resultSets;
        }
    }
}
