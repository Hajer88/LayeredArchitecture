using WebApplicationLayeredArchitecture.Models;

namespace WebApplicationLayeredArchitecture.Services;

public interface IMovieService
{
    public Task<List<Movie>> GetAllMoviesService();
    public Task<List<Movie>> GetMovieByGenre();
}