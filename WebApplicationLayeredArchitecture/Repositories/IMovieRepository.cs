using WebApplicationLayeredArchitecture.Models;

namespace WebApplicationLayeredArchitecture.Repositories;

public interface IMovieRepository
{
    public Task<List<Movie>> GetAllMoviesAsync();
}