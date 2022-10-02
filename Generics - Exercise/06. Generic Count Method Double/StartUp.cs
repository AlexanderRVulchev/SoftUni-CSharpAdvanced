//Use the description of the previous problem, but now, test your list of generic boxes with doubles.


using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    internal class StartUp
    {
        static void Main()
        {
            List<Box<double>> boxes = new List<Box<double>>();
            int numberOfEntries = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfEntries; i++)
            {
                double entry = double.Parse(Console.ReadLine());
                boxes.Add(new Box<double>(entry));
            }
            double item = double.Parse(Console.ReadLine());
            Console.WriteLine(Box<double>.GetCountOfLargerElements(boxes, item));
        }
    }
}
