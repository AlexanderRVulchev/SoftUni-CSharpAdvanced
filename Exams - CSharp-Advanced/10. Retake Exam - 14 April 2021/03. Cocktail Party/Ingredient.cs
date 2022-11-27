using System;


namespace CocktailParty
{
    public class Ingredient
    {
        public string Name { get; set; }
        public int Alcohol { get; set; }
        public int Quantity { get; set; }

        public Ingredient(string name, int alcohol, int quantity)
        {
            this.Name = name;
            this.Alcohol = alcohol;
            this.Quantity = quantity;
        }

        public override string ToString()
            => $"Ingredient: {this.Name}" + Environment.NewLine +
               $"Quantity: {this.Quantity}" + Environment.NewLine +
               $"Alcohol: {this.Alcohol}";
    }
}
