using EntityFrameworkConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books {  get; set; }
       public  DbSet<Author> Authors { get; set; }
        public DbSet<Library> Libraries { get; set; }
       public DbSet<AuthorBook > AuthorBooks { get; set; }    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SIRIUS05;Database=BookLibraryERP;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
