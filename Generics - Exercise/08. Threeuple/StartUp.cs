//Create a Class Threeuple. Its name is telling us, that it will hold no longer,
//just a pair of objects. The task is simple, our Threeuple should hold three objects.
//Make it have getters and setters. You can even extend the previous class
//Input
//The input consists of three lines:
//•	The first one is holding a name, an address and a town. Format of the input:
//{ first name}
//{ last name}
//{ address}
//{ town}
//•	The second line is holding a name, beer liters,
//and a boolean variable with value - drunk or not. Format:
//{ name}
//{ liters of beer}
//{ drunk or not}
//•	The last line will hold a name, a bank balance (double) and a bank name. Format:
//{ name}
//{ account balance}
//{ bank name}
//Output
//•	Print the Threeuples' objects in format:
//"{firstElement} -> {secondElement} -> {thirdElement}"



using System;
using System.Linq;

namespace Threeuple
{
    public class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string fullName = string.Join(" ", input.Split().Take(2));
            string address = input.Split().Skip(2).First();
            string town = input.Split().Last();
            var threeuple1 = new Threeuple<string, string, string>(fullName, address, town);

            input = Console.ReadLine();
            string drunkName = input.Split().First();
            int litersOfBeer = int.Parse(input.Split().Skip(1).First());
            bool isDrunk = input.Split().Last() == "drunk" ? true : false;
            var threeuple2 = new Threeuple<string, int, bool>(drunkName, litersOfBeer, isDrunk);

            input = Console.ReadLine();
            string name = input.Split().First();
            double balance = double.Parse(input.Split().Skip(1).First());
            string bankName = input.Split().Last();
            var threeuple3 = new Threeuple<string, double, string>(name, balance, bankName);

            Console.WriteLine(threeuple1);
            Console.WriteLine(threeuple2);
            Console.WriteLine(threeuple3);
        }
    }
}
