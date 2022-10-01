using System;

namespace GenericBoxOfInteger
{
    public class StartUp
    {
        static void Main()
        {
            int numberOfBoxes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfBoxes; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
