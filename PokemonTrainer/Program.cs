using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Trainer> trainers = new Dictionary<string,Trainer>();
            string input = Console.ReadLine();
            while (input!="Tournament")
            {
                string[] inputArr=input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string trainerName=inputArr[0];
                string pokemomName=inputArr[1];
                string pokemonElement=inputArr[2];
                int pokemonHealth=int.Parse(inputArr[3]);
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));

                }
                trainers[trainerName].PokemonCollection.Add(new Pokemon(pokemomName, pokemonElement, pokemonHealth));

                input = Console.ReadLine();
            }
            string command = Console.ReadLine();
            while (command!="End")
            {
                foreach (var trainer in trainers)
                {
                   bool HaveElement=false;
                    foreach (var pokemon in trainer.Value.PokemonCollection)
                    {
                        if (pokemon.Element.Contains(command))
                        {
                            HaveElement=true;
                            trainer.Value.NumberOfBadges++;
                            break;
                        }
                    }
                    if (!HaveElement)
                    {
                        trainer.Value.PokemonCollection.Select(x => x.Health -= 10).ToList();
                    }
                    trainer.Value.PokemonCollection.RemoveAll(x => x.Health <= 0);
                }

                command = Console.ReadLine();
            }
            
            foreach (var trainer in trainers.OrderByDescending(x=>x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.NumberOfBadges} {trainer.Value.PokemonCollection.Count}");
            }
        }
    }
}
