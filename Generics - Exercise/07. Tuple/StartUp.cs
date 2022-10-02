//A Tuple is a class in C#, in which you can store a few objects.
//First, we are going to focus on the Tuple's type, which contains two objects.
//The first one is "item1" and the second one is "item2". It is kind of like a KeyValuePair,
//except – it simply has items, which are neither key nor value.
//Your task is to create a class "Tuple", which holds two objects.
//The first one will be "item1" and the second one – "item2".
//The tricky part here is to make the class hold generics.
//This means, that when you create a new object of class – "Tuple",
//there should be a way to explicitly specify both items' types separately.
//Input
//The input consists of three lines:
//•	The first one is holding a person's name and an address.
//They are separated by space(s).
//Your task is to collect them in the tuple and print them on the console. Format of the input:
//{first name} { last name} { address}
//•	The second line holds a name of a person and the amount of beer (int) he can drink. Format:
//{name} {liters of beer}
//•	The last line will hold an integer and a double. Format:
//{integer} {double}
//Output
//•	Print the tuples’ items in format: { item1} -> { item2}


using System;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string fullName = string.Join(" ", input.Split().Take(2));
            string address = input.Split().Last();
            var tuple1 = new Tuple<string, string>(fullName, address);

            input = Console.ReadLine();
            string name = input.Split().First();
            int litersOfBeer = int.Parse(input.Split().Last());
            var tuple2 = new Tuple<string, int>(name, litersOfBeer);

            input = Console.ReadLine();
            int integerValue = int.Parse(input.Split().First());
            double doubleValue = double.Parse(input.Split().Last());
            var tuple3 = new Tuple<int, double>(integerValue, doubleValue);

            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
        }
    }
}
