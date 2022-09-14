//Create a program that:
//•	Records a car number for every car that enters the parking lot
//•	Removes a car number when the car leaves the parking lot
//The input will be a string in the format: "direction, carNumber".
//You will be receiving commands until the "END" command is given.
//Print the car numbers of the cars, which are still in the parking lot:
//•	Car numbers are unique
//•	Before printing, first, check if the set has any elements


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<string> cars = new HashSet<string>();
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string command = input.Split(", ").First();
            string car = input.Split(", ").Last();
            if (command == "IN")
                cars.Add(car);
            else if (command == "OUT")
                cars.Remove(car);
        }
        if (cars.Count > 0)
            Console.WriteLine(string.Join("\n", cars));
        else
            Console.WriteLine("Parking Lot is Empty");
    }
}