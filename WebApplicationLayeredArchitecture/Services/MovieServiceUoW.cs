using WebApplicationLayeredArchitecture.Models;
using WebApplicationLayeredArchitecture.Repositories;

namespace WebApplicationLayeredArchitecture.Services;

public class MovieServiceUoW
{
    private readonly IUnitOfWork _unitOfWork;

    public MovieServiceUoW(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<IEnumerable<Movie>> allMovies()
    {
        var c= _unitOfWork.Movies.GetAllAsync();
        //_unitOfWork.Complete();
        return c;

    }
}