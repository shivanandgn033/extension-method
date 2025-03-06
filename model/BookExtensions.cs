using System;

namespace extension_method;

public static class BookExtensions
{

        // Extension method to check if a book is a modern book (published after 2000).
    public static bool IsModern(this Book book)
    {
        return book.PublicationYear > 2000;
    }

    // Extension method to create a formatted string with additional information.
    public static string GetFormattedInfo(this Book book, string additionalInfo)
    {
        return $"{book.ToString()} - {additionalInfo}";
    }

    //Extension method that returns a new book with an updated publication year.
    public static Book WithUpdatedPublicationYear(this Book book, int newYear)
    {
        return new Book
        {
            Title = book.Title,
            Author = book.Author,
            PublicationYear = newYear
        };
    }

}


public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }

    public override string ToString()
    {
        return $"{Title} by {Author} ({PublicationYear})";
    }
}