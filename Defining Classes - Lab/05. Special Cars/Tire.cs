﻿using System;


namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double pressure;

        public int Year { get { return year; } set { year = value; } }
        public double Pressure { get { return pressure; } set { pressure = value; } }

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}
