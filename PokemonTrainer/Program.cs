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

            while (input[0] != "Tournament")
            {
                input = Console.ReadLine().Split().ToArray();
                if (input[0] == "Tournament") continue;
                switch (input.Length)
                {
                    case 1:
                        if (input[0] == "Tournament") continue;
                        break;
                    case 4:
                        {
                            if (input[0] == null)
                            {
                                Console.WriteLine("Trainer Name cannot be empty.");
                                break;
                            }
                            if (input[1] == null)
                            {
                                Console.WriteLine("Pokemon Name cannot be empty.");
                                break;
                            }
                            if (input[2] == null)
                            {
                                Console.WriteLine("Pokemon Power cannot be empty.");
                                break;
                            }
                            if (input[3] == null || Convert.ToInt32(input[3]) == 0)
                            {
                                Console.WriteLine("Pokemon Health cannot be zero.");
                                break;
                            }
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
                                if (!selectedTrainer.GetPokemons.Any(x => x.Name == Pokemon.Name))
                                    selectedTrainer.AddPokemon(Pokemon);
                            }
                            break;
                        }
                }
            }

            Console.WriteLine(new string('=', 50));

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
                    default:
                        Console.WriteLine("Choose between: Fire | Water | Electricity");
                        break;
                }
            } while (input[0] != "End");

            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Powers in Favor of the Tournament");
            Console.WriteLine($"Fire ({Fire}) | Water ({Water}) | Electricity ({Electricity})");
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Battle Log");
            Console.WriteLine(new string('-', 25));

            if (Fire > 0)
            {
                foreach (var trainer in Trainers.Where(x => x.GetPokemons.Any(y => y.Element == "Fire")))
                {
                    trainer.Badges += Fire;
                }
                foreach (var trainer in Trainers.Where(x => !x.GetPokemons.Any(y => y.Element == "Fire")))
                {
                    for (int i = 0; i < trainer.GetPokemons.Count(); i++)
                    {
                        var _tempPokemon = trainer.GetPokemons[i];
                        if (_tempPokemon.Health - 10 * Fire <= 0)
                        {
                            Console.WriteLine($"{Trainers.FirstOrDefault(x => x.GetPokemons.Any(y => y.Name == _tempPokemon.Name)).Name} ({_tempPokemon.Name}) died");
                        }
                        else
                            Console.WriteLine($"{Trainers.FirstOrDefault(x => x.GetPokemons.Any(y => y.Name == _tempPokemon.Name)).Name} ({_tempPokemon.Name}) took {10 * Fire} Fire Damage");
                        trainer.PokemonTakeDamage(_tempPokemon, 10 * Fire);
                    }
                }
            }
            if (Water > 0)
            {
                foreach (var trainer in Trainers.Where(x => x.GetPokemons.Any(y => y.Element == "Water")))
                {
                    trainer.Badges += Water;
                }
                foreach (var trainer in Trainers.Where(x => !x.GetPokemons.Any(y => y.Element == "Water")))
                {
                    for (int i = 0; i < trainer.GetPokemons.Count(); i++)
                    {
                        var _tempPokemon = trainer.GetPokemons[i];
                        if (_tempPokemon.Health - 10 * Water <= 0)
                        {
                            Console.WriteLine($"{Trainers.FirstOrDefault(x => x.GetPokemons.Any(y => y.Name == _tempPokemon.Name)).Name} ({_tempPokemon.Name}) died");
                        }
                        else
                            Console.WriteLine($"{Trainers.FirstOrDefault(x => x.GetPokemons.Any(y => y.Name == _tempPokemon.Name)).Name} ({_tempPokemon.Name}) took {10 * Water} Water Damage");
                        trainer.PokemonTakeDamage(_tempPokemon, 10 * Water);
                    }
                }
            }
            if (Electricity > 0)
            {
                foreach (var trainer in Trainers.Where(x => x.GetPokemons.Any(y => y.Element == "Electricity")))
                {
                    trainer.Badges += Electricity;
                }
                foreach (var trainer in Trainers.Where(x => !x.GetPokemons.Any(y => y.Element == "Electricity")))
                {
                    for(int i = 0; i < trainer.GetPokemons.Count(); i++)
                    {
                        var _tempPokemon = trainer.GetPokemons[i];
                        if (_tempPokemon.Health - 10 * Electricity <= 0)
                        {
                            Console.WriteLine($"{Trainers.FirstOrDefault(x => x.GetPokemons.Any(y => y.Name == _tempPokemon.Name)).Name} ({_tempPokemon.Name}) died");
                        }
                        else
                            Console.WriteLine($"{Trainers.FirstOrDefault(x => x.GetPokemons.Any(y => y.Name == _tempPokemon.Name)).Name} ({_tempPokemon.Name}) took {10 * Electricity} Electricity Damage");
                        trainer.PokemonTakeDamage(_tempPokemon, 10 * Electricity);
                    }
                }
            }

            Console.WriteLine(new string('-', 25));
            Console.WriteLine("End of Battle Log");
            Console.WriteLine(new string('=', 50));

            foreach (var trainer in Trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"Trainer Name: {trainer.Name} | Badges: {trainer.Badges} | Pokemons: {string.Join(", ", trainer.GetPokemons.Select(x => x.Name))}");
            }
        }
    }
}
