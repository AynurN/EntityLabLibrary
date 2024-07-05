using EntityFrameworkConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp.Interfaces
{
    public interface ILibraryService
    {
        void Add(Library library);
        Library Get(int id);
        List<Library> GetAll();
        List<Library> GetByBook(string bookName);
    }
}
