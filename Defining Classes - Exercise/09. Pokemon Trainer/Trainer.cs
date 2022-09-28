using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public string Name { get { return name; } set { name = value; } }
        public int Badges { get { return badges; } set { badges = value; } }
        public List<Pokemon> Pokemons { get { return pokemons; } set { pokemons = value; } }

        public Trainer(string trainerName)
        {
            this.Name = trainerName;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public Trainer(string trainerName, string pokemonName, string element, int health)
            : this(trainerName)
        {
            this.Pokemons.Add(new Pokemon(pokemonName, element, health));
        }

        public override string ToString() =>
        $"{this.Name} {this.Badges} {this.Pokemons.Count}";
    }
}
