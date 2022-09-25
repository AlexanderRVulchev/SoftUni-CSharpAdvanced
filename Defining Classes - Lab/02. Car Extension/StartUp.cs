//NOTE: You need a StartUp class with the namespace CarManufacturer.
//Create a class Car (you can use the class from the previous task)
//The class should have private fields for:
//•	make: string
//•	model: string
//•	year: int
//•	fuelQuantity: double
//•	fuelConsumption: double
//The class should also have properties for:
//•	Make: string
//•	Model: string
//•	Year: int
//•	FuelQuantity: double
//•	FuelConsumption: double
//The class should also have methods for:
//•	Drive(double distance) : void – This method checks if the car fuel quantity
//minus the distance multiplied by the car fuel consumption is bigger than zero.
//If it is removed from the fuel quantity the result of the multiplication
//between the distance and the fuel consumption.Otherwise,
//write on the console the following message:  
//"Not enough fuel to perform this trip!"
//•	WhoAmI() : string – returns the following message: 
//"Make: {this.Make}
// Model: {this.Model}
//Year: {this.Year}
//Fuel: {this.FuelQuantity:F2}"


using System;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        class Car
        {
            private string make;
            private string model;
            private int year;
            private double fuelQuantity;
            private double fuelConsumption;

            public string Make { get { return make; } set { make = value; } }
            public string Model { get { return model; } set { model = value; } }
            public int Year { get { return year; } set { year = value; } }
            public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }
            public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }

            public void Drive(double distance)
            {
                double fuelToSpend = distance * this.fuelConsumption;
                if (this.fuelConsumption - fuelToSpend >= 0)
                    this.fuelQuantity -= fuelToSpend;
                else
                    Console.WriteLine("Not enough fuel to perform this trip!");
            }

            public string WhoAmI()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Make: {this.Make}");
                sb.AppendLine($"Model: {this.Model}");
                sb.AppendLine($"Year: {this.Year}");
                sb.AppendLine($"Fuel: {this.FuelQuantity:f2}");                               
                return sb.ToString();
            }
        }

        public static void Main()
        {

        }
    }
}