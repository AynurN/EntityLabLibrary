using EntityFrameworkConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp.Interfaces
{
    public interface IAuthorService
    {
        void Add(Author author);
        List<Author> GetAll();
        List<Author> GetByBook(string bookName);
        List<Author> GetByName(string name);

    }
}
