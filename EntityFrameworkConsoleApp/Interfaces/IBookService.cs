using EntityFrameworkConsoleApp.Constants;
using EntityFrameworkConsoleApp.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp.Interfaces
{
    public interface IBookService
    {
        void Add(Book book);
        List<Book> GetAll();
        List<Book> GetBookByLibrary(string libraryName);
        List<Book> GetBookByAuthor(string authorName);
        List<Book> GetBookByName(string name);
        List<Book> GetBookByGenre(Genre genreName);
        void AssignAuthorToBook(string authorName, string bookName);
    }
}
