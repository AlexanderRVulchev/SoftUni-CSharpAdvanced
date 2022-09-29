//Create a class Box<> that can store anything. It should have two public methods:
//•	void Add(element) – adds an element on the top of the list.
//•	element Remove() – removes the topmost element.
//•	int Count { get; }


using System;

namespace BoxOfT
{
    public class StartUp
    {
        public static void Main()
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());
        }
    }
}
