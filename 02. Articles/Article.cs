class Article
{
    //properties
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    //constructor
    public Article (string title, string content, string author)
    {
        this.Title = title;
        this.Content = content;
        this.Author = author;
    }
    public void Edit (string newContent)
    {
        this.Content = newContent;
    }
    public void ChangeAuthor (string newAuthor)
    {
        this.Author = newAuthor;
    }
    public void Rename (string newTitle)
    {
        this.Title = newTitle;
    }

    //default methods -> ToString() Примерно
    public override string ToString() // force ovveride default method
    {
        return $"{Title} - {Content}: {Author}";
    }
}

