using Microsoft.EntityFrameworkCore;

namespace NewDb.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
        { }

        public DbSet<Movie> Movie { get; set; }
    }
}