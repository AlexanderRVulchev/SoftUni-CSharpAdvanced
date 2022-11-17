using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }
        public int Days { get; set; }
        public bool Hired { get; set; }

        public Renovator(string name, string type, double rate, int days)
        {
            this.Name = name;
            this.Type = type;
            this.Rate = rate;
            this.Days = days;
            this.Hired = false;
        }

        public override string ToString()
        =>  $"-Renovator: {this.Name}" + Environment.NewLine +
            $"--Specialty: {this.Type}" + Environment.NewLine +
            $"--Rate per day: {this.Rate} BGN";
    }
}
