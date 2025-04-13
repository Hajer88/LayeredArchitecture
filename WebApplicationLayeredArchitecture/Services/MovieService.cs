using WebApplicationLayeredArchitecture.Models;
using WebApplicationLayeredArchitecture.Repositories;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationLayeredArchitecture.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository _movieRepository)
    {
            this._movieRepository = _movieRepository;
    }


    public Task<List<Movie>> GetAllMoviesService()
    {
        return _movieRepository.GetAllMoviesAsync();
    }

    public async Task<List<Movie>> GetMovieByGenre()
    {
        var moviebyGenre = await _movieRepository.GetAllMoviesAsync();
        var result = moviebyGenre.Where(c=>c.genre.genre=="Fiction").ToList();
       /* var result = from movies in moviebyGenre 
            where (c=>c.genre.Name=="genre 1")
                select movies;*/
        
        return result;

    }
}