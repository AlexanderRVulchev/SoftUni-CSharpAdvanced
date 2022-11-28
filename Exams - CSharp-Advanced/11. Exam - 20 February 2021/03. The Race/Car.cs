using System;
using System.Collections.Generic;
using System.Text;

namespace TheRace
{
    public class Car
    {        
        public string Name { get; set; }
        public int Speed { get; set; }

        public Car(string name, int speed)
        {
            this.Name = name;
            this.Speed = speed;
        }
    }
}
