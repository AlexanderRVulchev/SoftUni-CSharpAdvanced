using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            int differenceInDays = DateModifier.GetDateDifference(firstDate, secondDate);
            Console.WriteLine(differenceInDays);
        }
    }
}