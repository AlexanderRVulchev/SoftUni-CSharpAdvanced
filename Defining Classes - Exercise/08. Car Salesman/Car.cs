using System;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        // Fields
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        // Properties
        public string Model { get { return model; } set { model = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public int Weight { get { return weight; } set { weight = value; } }
        public string Color { get { return color; } set { color = value; } }

        // Constructors
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        // Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string weightText = this.Weight == 0 ? "n/a" : this.Weight.ToString();
            string colorText = this.Color == null ? "n/a" : this.Color.ToString();

            sb.AppendLine($"{this.Model}:");
            sb.Append(this.Engine.ToString());
            sb.AppendLine($"  Weight: {weightText}");
            sb.Append($"  Color: {colorText}");
            return sb.ToString();
        }
    }
}
