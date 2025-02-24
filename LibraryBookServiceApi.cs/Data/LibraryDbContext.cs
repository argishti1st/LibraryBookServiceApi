using Microsoft.EntityFrameworkCore;

namespace LibraryBookServiceApi.cs.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options)
        {            
        }

        public DbSet<BookDb> Books { get; set; }
    }
}
