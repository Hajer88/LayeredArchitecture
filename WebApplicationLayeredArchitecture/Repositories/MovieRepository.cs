using Microsoft.EntityFrameworkCore;
using WebApplicationLayeredArchitecture.Models;

namespace WebApplicationLayeredArchitecture.Repositories;

public class MovieRepository : IMovieRepository
{
 private readonly Appdbcontext _db;

 public MovieRepository(Appdbcontext _db)
 {
   this._db = _db;
 }

 public Task<List<Movie>> GetAllMoviesAsync()
 {
    // var movies=  _db.movies.OrderBy(c=>c.Title).ToListAsync();
     var movies=  _db.movies.ToListAsync();
     return movies;
 }
}