using EntityFrameworkConsoleApp.Constants;
using EntityFrameworkConsoleApp.Interfaces;
using EntityFrameworkConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp.Implementations
{
    public class BookService : IBookService
    {
        AppDbContext context=new AppDbContext();
        public void Add(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            
        }

        public List<Book> GetAll()
        {
            return context.Books.ToList();
        }

        public List<Book> GetBookByAuthor(string authorName)
        {
            List<AuthorBook> authorBook=context.AuthorBooks.Where(x=>x.Author.Name==authorName).Include(x => x.Book).ThenInclude(x => x.Authors).ToList();
            List<Book> newList = new List<Book>();
            foreach (var item in authorBook)
            {
                newList.Add(item.Book);
            }
            return newList;
        }

        public List<Book> GetBookByLibrary(string libraryName)
        {
            return context.Books.Include(x => x.Library).Where(x => x.Library.Name==libraryName).ToList();
        }

        public List<Book> GetBookByName(string name)
        {
            return context.Books.Where(x=> x.Name==name).ToList();  
        }
        public List<Book> GetBookByGenre(Genre genreName)
        {
            return context.Books.Where(x => x.Genre == genreName).ToList();
        }

        public void AssignAuthorToBook(string authorName, string bookName)
        {
           Author? author=context.Authors.FirstOrDefault(x=>x.Name==authorName);
            Book? book=context.Books.FirstOrDefault(x=>x.Name==bookName);
            if(author==null || book==null)
            {
                throw new NullReferenceException();
            }
            author.Books.Add(book);
            book.Authors.Add(author);
            context.SaveChanges();
        }
    }
}
