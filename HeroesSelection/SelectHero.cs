using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesSelection
{
    class SelectHero
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> heroes = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "Make a decision already!")
                {
                    break;
                }


                if (input.Contains("does Gyubek!"))
                {
                    string[] currentLine = input
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

                    string name = currentLine[0];

                    // Remove all positive traits in the hero with this name
                    if (heroes.ContainsKey(name))
                    {
                        Dictionary<string, int> remainingTraits = new Dictionary<string, int>();

                        foreach (var item in heroes[name])
                        {
                            if (item.Value < 0)
                            {
                                remainingTraits.Add(item.Key, item.Value);
                            }
                        }
                        heroes[name] = remainingTraits;
                    }
                }
                else
                {
                    string[] line = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                    string heroesName = line[0];


                    string trait = line[1];
                    int traitValue = int.Parse(line[2]);

                    if (trait == "Greedy" || trait == "Rude" || trait == "Dumb")
                    {
                        traitValue = traitValue * (-1);
                    }

                    if (trait == "Kind")
                    {
                        traitValue = traitValue * 2;
                    }

                    if (trait == "Handsome")
                    {
                        traitValue = traitValue * 3;
                    }

                    if (trait == "Smart")
                    {
                        traitValue = traitValue * 5;
                    }

                    if (!heroes.ContainsKey(heroesName))
                    {
                        Dictionary<string, int> current = new Dictionary<string, int>();
                        current.Add(trait, traitValue);
                        heroes.Add(heroesName, current);
                    }
                    else if (!heroes[heroesName].ContainsKey(trait))
                    {
                        heroes[heroesName].Add(trait, traitValue);
                    }
                    else if (heroes[heroesName][trait] < traitValue)
                    {
                        heroes[heroesName][trait] = traitValue;
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var item in heroes.OrderByDescending(z => z.Value.Values.Sum()).ThenBy(m => m.Key))
            {
                Console.WriteLine($"# {item.Key}: {item.Value.Values.Sum()}");

                foreach (var kvp in item.Value.OrderByDescending(n => n.Value))
                {
                    Console.WriteLine($"!!! {kvp.Key} -> {kvp.Value}");
                }

            }
        }
    }
}
