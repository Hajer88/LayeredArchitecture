using WebApplicationLayeredArchitecture.Models;
using WebApplicationLayeredArchitecture.Repositories;

namespace WebApplicationLayeredArchitecture.Services;

public class MoviesGenericService : IMoviesGenericService
{
    private readonly IGenericRepository<Movie> _movieRepo;
    public MoviesGenericService(IGenericRepository<Movie> _movieRepo)
    {
            this._movieRepo = _movieRepo;
    }
    public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
    {
        return await this._movieRepo.GetAllAsync();
    }
}