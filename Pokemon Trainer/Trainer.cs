class Trainer
{
    public string Name { get; }
    public int Badges { get; set; }
    public List<Pokemon> PokemonCollection { get; }

    public Trainer(string name)
    {
        Name = name;
        Badges = 0;
        PokemonCollection = new List<Pokemon>();
    }
}

class Pokemon
{
    public string Name { get; }
    public string Element { get; }
    public int Health { get; set; }

    public Pokemon(string name, string element, int health)
    {
        Name = name;
        Element = element;
        Health = health;
    }
}