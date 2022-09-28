using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                cars.Add(new Car(carInfo));
            }
            
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (Car car in cars
                    .Where(c => 
                           c.Cargo.Type == "fragile" &&
                           c.Tires.Any(t => t.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flammable")
            {
                foreach (Car car in cars
                    .Where(c =>
                           c.Cargo.Type == "flammable" &&
                           c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
                
            }
        }
    }
}
