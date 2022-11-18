namespace FishingNet
{
    public class Fish
    {        
        public string FishType { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }

        public Fish(string fishType, double length, double weight)
        {
            this.FishType = fishType;
            this.Length = length;
            this.Weight = weight;
        }

        public override string ToString()
            => $"There is a {this.FishType}, {this.Length} cm. long, and {this.Weight} gr. in weight.";
    }
}
