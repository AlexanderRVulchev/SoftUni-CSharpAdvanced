//This is the final and most interesting problem in this lab.
//Until you receive the command "No more tires", you will be given tire info in the format:
//{ year} { pressure}
//{ year} { pressure}
//…
//"No more tires"
//You have to collect all the tires provided.
//Next, until you receive the command "Engines done"
//you will be given engine info and you also have to collect all that info.
//{horsePower} { cubicCapacity}
//{ horsePower}
//{ cubicCapacity} 
//…
//The final step - until you receive "Show special",
//you will be given information about cars in the format:
//{ make} { model} { year} { fuelQuantity} { fuelConsumption} { engineIndex} { tiresIndex}
//…
//Every time you have to create a new Car with the information provided.
//The car engine is the provided engineIndex and the tires are tiresIndex.
//Finally, collect all the created cars. When you receive the command "Show special",
//drive 20 kilometers all the cars, which were manufactured during 2017 or after,
//have horsepower above 330 and the sum of their tire pressure is between 9 and 10.
//Finally, print information about each special car in the following format:
//"Make: {specialCar.Make}"
//"Model: {specialCar.Model}"
//"Year: {specialCar.Year}"
//"HorsePowers: {specialCar.Engine.HorsePower}"
//"FuelQuantity: {specialCar.FuelQuantity}"



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        class Car
        {
            // Fields
            private string make;
            private string model;
            private int year;
            private double fuelQuantity;
            private double fuelConsumption;
            private Engine engine;
            private Tire[] tires;

            // Properties
            public string Make { get { return make; } set { make = value; } }
            public string Model { get { return model; } set { model = value; } }
            public int Year { get { return year; } set { year = value; } }
            public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }
            public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }
            public Engine Engine { get { return engine; } set { engine = value; } }
            public Tire[] Tires { get { return tires; } set { tires = value; } }

            // Constructors
            public Car()
            {
                this.Make = "VW";
                this.Model = "Golf";
                this.Year = 2025;
                this.FuelQuantity = 200;
                this.FuelConsumption = 10;
            }

            public Car(string make, string model, int year) : this()
            {
                this.Make = make;
                this.Model = model;
                this.Year = year;
            }

            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
                : this(make, model, year)
            {
                this.FuelQuantity = fuelQuantity;
                this.FuelConsumption = fuelConsumption;
            }

            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
                : this(make, model, year, fuelQuantity, fuelConsumption)
            {
                this.Tires = tires;
                this.Engine = engine;
            }

            // Methods
            public void Drive(double distance)
            {
                double fuelToSpend = distance * this.fuelConsumption / 100;
                if (this.FuelQuantity - fuelToSpend >= 0)
                    this.FuelQuantity -= fuelToSpend;
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
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Make: {this.Make}");
                sb.AppendLine($"Model: {this.Model}");
                sb.AppendLine($"Year: {this.Year}");
                sb.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
                sb.Append($"FuelQuantity: {this.FuelQuantity}");
                return sb.ToString();
            }                                                
        }

        public static void Main()
        {
            List<Tire[]> tirePacks = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tireYearAndPressure = input.Split();
                Tire[] singleTires = new Tire[4];                
                int indexCounter = 0;
                for (int i = 0; i < 4; i ++)
                {
                    int tireYear = int.Parse(tireYearAndPressure[indexCounter]);                    
                    indexCounter++;
                    double pressureValue = double.Parse(tireYearAndPressure[indexCounter]);                    
                    singleTires[i] = new Tire(tireYear, pressureValue);
                    indexCounter++;
                }
                tirePacks.Add(singleTires);
            }

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = input.Split();
                int horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);
                engines.Add(new Engine(horsePower, cubicCapacity));
            }

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = input.Split();
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                Tire[] currentCarTires = tirePacks[tiresIndex];
                Engine currentCarEngine = engines[engineIndex];
                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, currentCarEngine, currentCarTires));
            }

            List<Car> specialCars = cars
                .FindAll(c => c.Year >= 2017
                           && c.Engine.HorsePower > 330
                           && c.Tires.Select(t => t.Pressure).Sum() >= 9
                           && c.Tires.Select(t => t.Pressure).Sum() <= 10);

            foreach (Car car in specialCars)                
            {
                car.Drive(20);
                Console.WriteLine(car);
            }

        }
    }
}