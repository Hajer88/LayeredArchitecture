using WebApplicationLayeredArchitecture.Models;

namespace WebApplicationLayeredArchitecture.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly Appdbcontext _context;

    public IGenericRepository<Movie> Movies { get; private set; }

    public UnitOfWork(Appdbcontext context)
    {
        _context = context;
        Movies = new GenericRepository<Movie>(_context);
        
    }

    public int Complete()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}