//Define a class Trainer and a class Pokemon. 
//Trainers have:
//•	Name
//•	Number of badges
//•	A collection of pokemon
//Pokemon have:
//•	Name
//•	Element
//•	Health
//All values are mandatory. Every Trainer starts with 0 badges.
//You will be receiving lines until you receive the command "Tournament".
//Each line will carry information about a pokemon and the trainer who caught it in the format:
//"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
//TrainerName is the name of the Trainer who caught the pokemon. Trainers’ names are unique.
//After receiving the command "Tournament",
//you will start receiving commands until the "End" command is received.
//They can contain one of the following:
//•	"Fire"
//•	"Water"
//•	"Electricity"
//For every command, you must check if a trainer has at least 1 pokemon with the given element.
//If he does, he receives 1 badge. Otherwise, all of his pokemon lose 10 health.
//If a pokemon falls to 0 or less health,
//he dies and must be deleted from the trainer’s collection.
//In the end, you should print all of the trainers,
//sorted by the number of badges they have in descending order
//(if two trainers have the same amount of badges,
//they should be sorted by order of appearance in the input) in the format: 
//"{trainerName} {badges} {numberOfPokemon}"



using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                ReadNewTrainerInfo(trainers, input);
            }
            while ((input = Console.ReadLine()) != "End")
            {
                ReadCommands(trainers, input);
            }
            foreach (Trainer trainer in trainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine(trainer);
            }
        }

        static void ReadNewTrainerInfo(List<Trainer> trainers, string input)
        {
            var command = new Queue<string>(input.Split());
            string trainerName = command.Dequeue();
            string pokemonName = command.Dequeue();
            string pokemonElement = command.Dequeue();
            int pokemonHealth = int.Parse(command.Dequeue());

            if (trainers.Any(t => t.Name == trainerName))
            {
                trainers
                    .Find(t => t.Name == trainerName).Pokemons
                    .Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }
            else
            {
                trainers.Add(new Trainer(trainerName, pokemonName, pokemonElement, pokemonHealth));
            }
        }

        static void ReadCommands(List<Trainer> trainers, string command)
        {
            for (int i = 0; i < trainers.Count; i++)
            {
                if (trainers[i].Pokemons.Any(p => p.Element == command))
                {
                    trainers[i].Badges++;
                }
                else
                {
                    DecreasePokemonsLifeBy10(trainers[i].Pokemons);
                }
            }
        }

        static void DecreasePokemonsLifeBy10(List<Pokemon> pokemons)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                pokemons[i].Health -= 10;
                if (pokemons[i].Health <= 0)
                    pokemons.RemoveAt(i);
            }
        }
    }
}
