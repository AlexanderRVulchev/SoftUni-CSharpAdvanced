using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        public List<Ingredient> Ingredients { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
        public int CurrentAlcoholLevel { get { return this.Ingredients.Select(i => i.Alcohol).Sum(); } }

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.MaxAlcoholLevel = maxAlcoholLevel;
            this.Ingredients = new List<Ingredient>();
        }

        
        public void Add(Ingredient ingredient)
        {
            if (!this.Ingredients.Any(i => i.Name == ingredient.Name) &&
                this.Capacity > this.Ingredients.Count &&
                ingredient.Alcohol + this.CurrentAlcoholLevel <= this.MaxAlcoholLevel)
            {
                this.Ingredients.Add(ingredient);
            }
        }
                
        public bool Remove(string name)
            => this.Ingredients.Remove(this.Ingredients.Find(i => i.Name == name));
        
        public Ingredient FindIngredient(string name)
            => this.Ingredients.Find(i => i.Name == name);
                
        public Ingredient GetMostAlcoholicIngredient()
            => this.Ingredients.OrderByDescending(i => i.Alcohol).FirstOrDefault();

        public string Report()
            => $"Cocktail: {this.Name} - Current Alcohol Level: {this.CurrentAlcoholLevel}" + 
               Environment.NewLine +
               string.Join(Environment.NewLine, this.Ingredients);
    }
}
