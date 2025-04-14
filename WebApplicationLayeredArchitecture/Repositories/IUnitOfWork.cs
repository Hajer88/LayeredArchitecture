using WebApplicationLayeredArchitecture.Models;

namespace WebApplicationLayeredArchitecture.Repositories;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Movie> Movies { get; }
   
    int Complete();
    void Dispose();
}
