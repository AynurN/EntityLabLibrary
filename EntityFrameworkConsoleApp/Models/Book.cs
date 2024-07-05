using EntityFrameworkConsoleApp.Constants;

namespace EntityFrameworkConsoleApp.Models;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public static DateTime Now { get; }
    public Genre Genre { get; set; }
    public int LibraryId { get; set; }
    public Library  Library { get; set; }
    public List<AuthorBook> AuthorBooks { get; set; }
    public List<Author> Authors { get; set; }
}
