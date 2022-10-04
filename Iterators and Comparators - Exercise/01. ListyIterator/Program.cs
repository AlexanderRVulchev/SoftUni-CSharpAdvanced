using System;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main()
        {
            string[] entries = Console.ReadLine().Split().Skip(1).ToArray();
            ListyIterator<string> listy = new ListyIterator<string>(entries);
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                switch(input)
                {
                    case "Move": Console.WriteLine(listy.Move()); break;
                    case "HasNext": Console.WriteLine(listy.HasNext()); break;
                    case "Print": listy.Print(); break;
                }
            }

        }
    }
}
