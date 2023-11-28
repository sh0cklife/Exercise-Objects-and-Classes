int teamCount = int.Parse(Console.ReadLine());

        Dictionary<string, Team> teams = new Dictionary<string, Team>();

        for (int i = 0; i < teamCount; i++)
        {
            string[] input = Console.ReadLine().Split('-');
            string creator = input[0];
            string teamName = input[1];

            if (teams.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
            }
            else if (teams.Any(t => t.Value.Creator == creator))
            {
                Console.WriteLine($"{creator} cannot create another team!");
            }
            else
            {
                Team team = new Team(teamName, creator);
                teams.Add(teamName, team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "end of assignment")
        {
            string[] input = command.Split("->");
            string user = input[0];
            string teamName = input[1];

            if (!teams.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
            }
            else if (teams.Any(t => t.Value.Creator == user || t.Value.Members.Contains(user)))
            {
                Console.WriteLine($"Member {user} cannot join team {teamName}!");
            }
            else
            {
                teams[teamName].Members.Add(user);
            }
        }

        foreach (var team in teams.OrderByDescending(t => t.Value.Members.Count).ThenBy(t => t.Key))
        {
            if (team.Value.Members.Count > 0)
            {
                Console.WriteLine($"{team.Key}");
                Console.WriteLine($"- {team.Value.Creator}");
                foreach (var member in team.Value.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }

        Console.WriteLine("Teams to disband:");
        foreach (var team in teams.Where(t => t.Value.Members.Count == 0).OrderBy(t => t.Key))
        {
            Console.WriteLine($"{team.Key}");
        }
    
