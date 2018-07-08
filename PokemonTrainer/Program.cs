using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonTrainer
{
    class Program
    {
        static void Main()
        {
            List<Trainer> Trainers = new List<Trainer>();
            string[] input = {""};
            do
            {
                input = Console.ReadLine().Split().ToArray();
                if (input[0] == "Tournament") continue;
                var TrainerName = input[0];
                Trainer selectedTrainer = null;
                if (Trainers.Any())
                    selectedTrainer = Trainers.FirstOrDefault(x => x != null && x.Name != null && x.Name == TrainerName);
                var Pokemon = new Pokemon(input[1], input[2], int.Parse(input[3]));
                if (selectedTrainer == null)
                {
                    Trainers.Add(new Trainer(TrainerName, 0, new Pokemon[] { Pokemon }));
                }
                else
                {
                    if (!selectedTrainer.PokemonCollection.Any(x => x.Name == Pokemon.Name))
                        selectedTrainer.AddPokemon(Pokemon);
                }
            } while (input[0] != "Tournament");

            int Fire = 0, Water = 0, Electricity = 0;

            do
            {
                input = Console.ReadLine().Split().ToArray();
                switch (input[0])
                {
                    case "Fire":
                        Fire++;
                        break;
                    case "Water":
                        Water++;
                        break;
                    case "Electricity":
                        Electricity++;
                        break;
                    case "End":
                        continue;
                }
            } while (input[0] != "End");

            if (Fire > 0)
            {
                foreach (var trainer in Trainers.Where(x => x.PokemonCollection.Any(y => y.Element == "Fire")))
                {
                    trainer.Badges += Fire;
                }
                foreach (var trainer in Trainers.Where(x => !x.PokemonCollection.Any(y => y.Element == "Fire")))
                {
                    for (int i = 0; i < trainer.PokemonCollection.Count(); i++)
                    {
                        trainer.PokemonTakeDamage(trainer.PokemonCollection[i], 10 * Fire);
                    }
                }
            }
            if (Water > 0)
            {
                foreach (var trainer in Trainers.Where(x => x.PokemonCollection.Any(y => y.Element == "Water")))
                {
                    trainer.Badges += Water;
                }
                foreach (var trainer in Trainers.Where(x => !x.PokemonCollection.Any(y => y.Element == "Water")))
                {
                    for (int i = 0; i < trainer.PokemonCollection.Count(); i++)
                    {
                        trainer.PokemonTakeDamage(trainer.PokemonCollection[i], 10 * Water);
                    }
                }
            }
            if (Electricity > 0)
            {
                foreach (var trainer in Trainers.Where(x => x.PokemonCollection.Any(y => y.Element == "Electricity")))
                {
                    trainer.Badges += Electricity;
                }
                foreach (var trainer in Trainers.Where(x => !x.PokemonCollection.Any(y => y.Element == "Electricity")))
                {
                    for(int i = 0; i < trainer.PokemonCollection.Count(); i++)
                    {
                        trainer.PokemonTakeDamage(trainer.PokemonCollection[i], 10 * Electricity);
                    }
                }
            }

            foreach (var trainer in Trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.PokemonCollection.Count()}");
            }
        }
    }
}
