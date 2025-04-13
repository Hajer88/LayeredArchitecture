using Microsoft.EntityFrameworkCore;

namespace WebApplicationLayeredArchitecture.Models;

public class Appdbcontext : DbContext
    {
    public Appdbcontext()
    {
    }

    public Appdbcontext(DbContextOptions<Appdbcontext> options)
        :base(options)
    {
    }

    public DbSet<Movie> movies{ get; set; }
    public DbSet<Genre> genres { get; set; }
}