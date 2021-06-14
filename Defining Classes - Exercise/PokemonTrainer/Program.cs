using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static int indexForPokemon { get; set; }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Trainer> listOfTrainers = new List<Trainer>();
            while (input != "Tournament")
            {
                string[] splitted = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Pokemon pokemon = new Pokemon(splitted[1], splitted[2], int.Parse(splitted[3]));
                if (listContains(splitted[0], listOfTrainers))
                {
                    listOfTrainers[indexForPokemon].Pokemons.Add(pokemon);
                }
                else
                {
                    Trainer trainer = new Trainer(splitted[0], new List<Pokemon> { pokemon});
                    listOfTrainers.Add(trainer);
                }
                
                input = Console.ReadLine();
            }
            string secondInput = Console.ReadLine();
            while (secondInput != "End")
            {
                if (secondInput == "Fire")
                {
                    CheckAllPokemonsForElement(secondInput, listOfTrainers);
                }
                else if (secondInput == "Water")
                {
                    CheckAllPokemonsForElement(secondInput, listOfTrainers);
                }
                else
                {
                    CheckAllPokemonsForElement(secondInput, listOfTrainers);
                }
                secondInput = Console.ReadLine();
            }
            foreach (var trainer in listOfTrainers.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }

        private static void CheckAllPokemonsForElement(string element, List<Trainer> listOfTrainers)
        {
            foreach (var trainer in listOfTrainers)
            {
                bool isAvailable = false;
                if (trainer.Pokemons.Count > 0)
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element == element)
                        {
                            trainer.NumberOfBadges++;
                            isAvailable = true;
                            break;
                        }
                    }
                    if (!isAvailable)
                    {
                        trainer.Pokemons.ForEach(pokemon => pokemon.Health -= 10);
                        trainer.Pokemons.RemoveAll(pokemon => pokemon.Health <= 0);
                        //foreach (var pokemon in trainer.Pokemons)
                        //{
                        //    pokemon.Health -= 10;
                        //    if (pokemon.Health <= 0)
                        //    {
                        //        trainer.Pokemons.Remove(pokemon);
                        //        if (trainer.Pokemons.Count <= 0)
                        //        {
                        //            break;
                        //        }
                        //    }
                        //}
                    }
                }
                
            }
        }

        private static bool listContains(string name, List<Trainer> trainers)
        {
            int count = 0;
            indexForPokemon = 0;
            foreach (var trainer in trainers)
            {
                if (trainer.Name == name)
                {
                    indexForPokemon = count;
                    return true;
                }
                count++;
            }
            return false;
        }
    }
}
