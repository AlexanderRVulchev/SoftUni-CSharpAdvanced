using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        private readonly List<Animal> animals;

        public List<Animal> Animals { get { return this.animals; } }        
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Zoo(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.animals = new List<Animal>();
        }
                
        public string AddAnimal(Animal animal)
        {
            if (string.IsNullOrWhiteSpace(animal.Species))
                return "Invalid animal species.";
            if (!new List<string> { "herbivore", "carnivore" }.Contains(animal.Diet))
                return "Invalid animal diet.";
            if (this.animals.Count >= this.Capacity)
                return "The zoo is full.";
            this.animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }
                
        public int RemoveAnimals(string species)
            => this.animals.RemoveAll(a => a.Species == species);
                
        public List<Animal> GetAnimalsByDiet(string diet)
            => this.animals.FindAll(a => a.Diet == diet);
                
        public Animal GetAnimalByWeight(double weight)
            => this.animals.Find(a => a.Weight == weight);
                
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = this.animals.Where(a => a.Length >= minimumLength && a.Length <= maximumLength).Count();
            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
