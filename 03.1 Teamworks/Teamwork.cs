class Team
{
    public string Name { get; }
    public string Creator { get; }
    public List<string> Members { get; }

    public Team(string name, string creator)
    {
        Name = name;
        Creator = creator;
        Members = new List<string>();
    }
}