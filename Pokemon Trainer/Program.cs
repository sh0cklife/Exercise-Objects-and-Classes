Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

string input;
while ((input = Console.ReadLine()) != "Tournament")
{
    string[] tokens = input.Split();
    string trainerName = tokens[0];
    string pokemonName = tokens[1];
    string pokemonElement = tokens[2];
    int pokemonHealth = int.Parse(tokens[3]);

    if (!trainers.ContainsKey(trainerName))
    {
        trainers.Add(trainerName, new Trainer(trainerName));
    }

    Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
    trainers[trainerName].PokemonCollection.Add(pokemon);
}

while ((input = Console.ReadLine()) != "End")
{
    foreach (var trainer in trainers.Values)
    {
        bool hasElement = trainer.PokemonCollection.Any(p => p.Element == input);

        if (hasElement)
        {
            trainer.Badges++;
        }
        else
        {
            foreach (var pokemon in trainer.PokemonCollection)
            {
                pokemon.Health -= 10;
            }

            trainer.PokemonCollection.RemoveAll(p => p.Health <= 0);
        }
    }
}

foreach (var trainer in trainers.OrderByDescending(t => t.Value.Badges))
{
    Console.WriteLine($"{trainer.Value.Name} {trainer.Value.Badges} {trainer.Value.PokemonCollection.Count}");
}
