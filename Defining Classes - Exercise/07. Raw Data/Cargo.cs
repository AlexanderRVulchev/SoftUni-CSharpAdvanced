using System;

namespace DefiningClasses
{
    public class Cargo
    {
        private string type;
        private int weight;
        
        public string Type { get { return type; } set { type = value; } }
        public int Weight { get { return weight; } set { weight = value; } }

        public Cargo(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
    }
}
