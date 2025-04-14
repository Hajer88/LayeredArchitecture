using WebApplicationLayeredArchitecture.Models;

namespace WebApplicationLayeredArchitecture.Services;

public interface IMoviesGenericService
{
    Task<IEnumerable<Movie>> GetAllMoviesAsync();
}