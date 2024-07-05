using EntityFrameworkConsoleApp.Implementations;
using EntityFrameworkConsoleApp.Interfaces;

namespace EntityFrameworkConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILibraryService library = new LibraryService();
            IBookService book= new BookService();
            IAuthorService author= new AuthorService();
            while (true)
            {
                ShowMenu();
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        library.GetAll().ForEach(x => Console.WriteLine(x));

                        break;
                    case "2":
                        book.GetAll().ForEach(x => Console.WriteLine(x));
                        break;
                    case "3":
                        author.GetAll().ForEach(x => Console.WriteLine(x));
                        break;
                    case "4":
                        {
                            Console.WriteLine("Library name:");
                            string s= Console.ReadLine();
                            book.GetBookByLibrary(s).ForEach(x => Console.WriteLine(x));
                        }
                        break;
                    case "5":
                        {
                            Console.WriteLine("Author name:");
                            string s=Console.ReadLine();
                            book.GetBookByAuthor(s).ForEach(x => Console.WriteLine(x));
                        }

                        break;
                    case "6":
                        {
                            Console.WriteLine("Book name:");
                            string s=Console.ReadLine();
                            author.GetByBook(s).ForEach(x => Console.WriteLine(x));
                        }

                        break;
                    case "7":
                        {

                        }
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    case "10":
                        break;
                    case "11":
                        break;
                    case "12":
                        break;
                    case "13":
                        break;
                    case "14":
                        break;
                    case "15":
                        break;
                    case "0":
                        {
                            Console.WriteLine("Program exited!");
                            return;
                        }
                        
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input");
                        Console.ResetColor();
                        break;
                }
            }
        }
        private static void ShowMenu()
        {
            Console.WriteLine("""
                              0. Exit
                              1. Show All Libraries
                              2. Show All Books
                              3. Show All Authors
                              4. Show Books by Library
                              5. Show Books by Author
                              6. Show Authors by Books
                              7. Show All Books with Authors
                              8. Show All Libraries with Books
                              9. Add Library
                              10. Add Book
                              11. Add Author
                              12. Assign Author to Book
                              13. Find Book by Title
                              14. Find Author by Name
                              15. Find Books By Genre
                              """);
            Console.WriteLine();
            Console.Write("Enter menu number : ");
        }

        //private static string GetInput(string inputMessage)
        //{
        //    Console.Write(inputMessage);
        //    string input = Console.ReadLine();
        //    if (string.IsNullOrEmpty(input))
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Input can't be empty");
        //        Console.ResetColor();
        //        return GetInput(inputMessage);
        //    }
        //    return input;
        //}

        //private static int GetValidInput(string inputMessage)
        //{
        //    Console.Write(inputMessage);

        //    string input = Console.ReadLine();
        //    bool isValid = int.TryParse(input, out int result);

        //    if (!isValid || result < 0)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Invalid input");
        //        Console.ResetColor();
        //        return GetValidInput(inputMessage);
        //    }
        //    return result;
        }
    }
}
