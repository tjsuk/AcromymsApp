namespace Acromyms;

public class Library
{
    public Book CreateBook(string title, string author)
    {
        return new Book(title, author);
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}
