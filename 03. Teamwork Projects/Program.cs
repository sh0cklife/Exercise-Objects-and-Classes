int countTeams = int.Parse(Console.ReadLine());
Dictionary<string, Team> teams = new Dictionary<string, Team>();

for (int i = 0; i <= countTeams; i++)
{
    string teamData = Console.ReadLine();
    string creator = teamData.Split("-")[0];
    string teamName = teamData.Split("-")[1];

    Team team = new Team(teamName, creator);
    Console.WriteLine($"Team {teamName} has been created by {creator}!");
    teams.Add(teamName, team);
}

// Модификация, включване в отбори
string command = Console.ReadLine();

while (command != "end of assignment")
{
    //Peter->PowerPuffsCoders
    string memberJoin = command.Split("->")[0]; //Peter
    string teamJoining = command.Split("->")[1]; //PowerPuffCoders

    teams[teamJoining].Members.Add(memberJoin); //премествам memberMoving в teamJoining в чрез речника

    command = Console.ReadLine();
}

// OUTPUT:
//1. Принтираме отборите които имат членове вътре в тях

foreach (var team in teams.Where(team => team.Value.Members.Count > 0) // оставяме само отборите с повече от 0 членове
                            .OrderByDescending(team => team.Value.Members.Count) // сорт по брой хора в отбор
                            .ThenBy(team => team.Key)) // по име на отбора (нарастващ ред) ако имат еднакъв брой хора
{
    Console.WriteLine(team.Key);
    Console.WriteLine("- " + team.Value.Creator);
    
    foreach (string member in team.Value.Members.OrderBy(m => m))
    {
        Console.WriteLine("-- " + member);
    }
}
//2. Отбори с членове
Console.WriteLine("Teams to disband: ");
foreach (var team in teams.Where(team => team.Value.Members.Count == 0)) // оставяме само отборите с 0 членове
{
    Console.WriteLine(team.Key);
} 
                            

