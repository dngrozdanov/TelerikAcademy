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

            while(Console.ReadLine() != "Tournament")
            {
                var input = Console.ReadLine().Split().ToArray();
                var TrainerName = input[0];
                var Pokemon = new Pokemon(input[1], input[2], int.Parse(input[3]));
                if (!Trainers.Any(x => x.Name == TrainerName))
                {
                    Trainers.Add(new Trainer(TrainerName, 0, null));
                    var selectedTrainer = Trainers.First(x => x.Name == TrainerName);
                    selectedTrainer.AddPokemon(Pokemon);
                }
                else
                {
                    var selectedTrainer = Trainers.First(x => x.Name == TrainerName);
                    if (!selectedTrainer.PokemonCollection.Any(x => x.Name == Pokemon.Name))
                        selectedTrainer.AddPokemon(Pokemon);
                }
            }

            /*while (Console.ReadLine() != "End")
            {

            }*/
        }
    }
}
