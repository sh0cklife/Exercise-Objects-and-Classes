using System.Runtime.CompilerServices;

string articleData = Console.ReadLine(); //Fight club, love story, Martin Scorsese
string title = articleData.Split(", ")[0]; //Fight club
string content = articleData.Split(", ")[1]; //love story
string author = articleData.Split(", ")[2]; //Martin Scorsese

Article article = new Article(title, content, author); // по конструктор създаваме обект (статия)

int countCommands = int.Parse(Console.ReadLine()); // брой команди въведине на втория ред от конзолата
for (int i = 1; i <= countCommands; i++)
{
    string command = Console.ReadLine();
    string[] commandParts = command.Split(": "); 
    string commandName = commandParts[0]; // "Edit" || "ChangeAuthor" || "Rename"
    string commandValue = commandParts[1]; // {new content} || {new author} || {new title}

    switch (commandName)
    {
        case "Edit":
            article.Edit(commandValue);
            break;
        case "ChangeAuthor":
            article.ChangeAuthor(commandValue);
            break;
        case "Rename":
            article.Rename(commandValue);
            break;
    }
}

//Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
Console.WriteLine(article);
