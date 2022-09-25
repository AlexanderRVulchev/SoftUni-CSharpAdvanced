//NOTE: You need a StartUp class with the namespace CarManufacturer.
//Create a class named Car.The class should have private fields for:
//•	make: string
//•	model: string
//•	year: int
//The class should also have public properties for:
//•	Make: string
//•	Model: string
//•	Year: int


using System;

namespace CarManufacturer
{
    public class StartUp
    {
        class Car
        {
            private string make;
            private string model;
            private int year;

            public string Make { get { return make; } set { make = value; } }
            public string Model { get { return model; } set { model = value; } }
            public int Year { get { return year; } set { year = value; } }
        }

        static void Main()
        {
            
        }
    }
}
