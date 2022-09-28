﻿using System;


namespace DefiningClasses
{
    public class Tire
    {
        private int age;
        private double pressure;
        
        public int Age { get { return age; } set { age = value; } }
        public double Pressure { get { return pressure; } set { pressure = value; } }

        public Tire(int age, double pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
    }
}
