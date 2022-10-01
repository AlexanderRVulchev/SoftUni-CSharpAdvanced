using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main()
        {
            int numberOfBoxes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfBoxes; i++)
            {
                var input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
