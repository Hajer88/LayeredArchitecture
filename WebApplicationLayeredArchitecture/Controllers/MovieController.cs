using Microsoft.AspNetCore.Mvc;
using WebApplicationLayeredArchitecture.Services;

namespace WebApplicationLayeredArchitecture.Controllers;

public class MovieController : Controller
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService _movieService)
    {
            this._movieService = _movieService;
    }
    // GET
    public async Task<IActionResult> Index()
    {
        var c = await _movieService.GetAllMoviesService();
        
        return View(c);
    }
}