using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework.Models
{
    class BooksDbContext : DbContext
    {
        public BooksDbContext() : base("name=BooksDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BooksDbContext, Configuration>());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
