using Microsoft.EntityFrameworkCore;
using WebApplicationLayeredArchitecture.Models;

namespace WebApplicationLayeredArchitecture.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly Appdbcontext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(Appdbcontext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }
}
