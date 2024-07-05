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
    public class AuthorService : IAuthorService
    {
        AppDbContext context=new AppDbContext();
        public void Add(Author author)
        {
           context.Add(author);
            context.SaveChanges();
        }

        public List<Author> GetAll()
        {
            return context.Authors.ToList();
        }

        public List<Author> GetByBook(string bookName)
        {
            List<AuthorBook> authorBook = context.AuthorBooks.Where(x => x.Book.Name == bookName).Include(x=> x.Book).ThenInclude(x=>x.Authors).ToList();
            List<Author> newList = new List<Author>();
            foreach (var item in authorBook)
            {
                newList.Add(item.Author);
            }
            return newList;
        }

        public List<Author> GetByName(string name)
        {
            return context.Authors.Where(x=> x.Name==name).ToList();
        }
    }
}
