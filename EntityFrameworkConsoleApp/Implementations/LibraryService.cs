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
    public class LibraryService : ILibraryService
    {
        AppDbContext dbContext = new AppDbContext();
        public void Add(Library library)
        {
            dbContext.Libraries.Add(library);
            dbContext.SaveChanges();
        }

        public Library Get(int id)
        {
           Library? searched=dbContext.Libraries.Find(id);
            if (searched == null)
                throw new NullReferenceException();
            return searched;
        }

        public List<Library> GetAll()
        {
            return dbContext.Libraries.ToList();
          
        }

        public List<Library> GetByBook(string bookName)
        {
            List<Library> newList= new List<Library>();
            Book? book= dbContext.Books.Include(x=>x.Library).FirstOrDefault(x=>x.Name==bookName);
            if (book == null)
                throw new NullReferenceException();
            foreach (var lib in dbContext.Libraries)
            {
                if(lib.Books.Contains(book))
                    newList.Add(lib);
                
            }
            return newList;
        }
    }
}
