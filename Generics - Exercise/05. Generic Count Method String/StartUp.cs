//Create a method that receives as an argument a list of any type,
//that can be compared and an element of the given type.
//The method should return the count of elements
//that are greater than the value of the given element.
//Modify your Box class to support comparison by value of the stored data.
//Input
//•	 On the first line, you will receive n - the number of elements to add to the list.
//•	 On the next n lines, you will receive the actual elements.
//•	 On the last line, you will get the value of the element for comparison.
//Output
//•	Print the count of elements that are larger than the value of the given element.


using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    internal class StartUp
    {
        static void Main()
        {
            List<Box<string>> boxes = new List<Box<string>>();
            int numberOfEntries = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfEntries; i++)
            {
                boxes.Add(new Box<string>(Console.ReadLine()));
            }
            string item = Console.ReadLine();
            Console.WriteLine(Box<string>.GetCountOfLargerElements(boxes, item));
        }
    }
}
