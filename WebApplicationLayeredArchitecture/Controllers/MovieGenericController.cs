using Microsoft.AspNetCore.Mvc;
using WebApplicationLayeredArchitecture.Services;

namespace WebApplicationLayeredArchitecture.Controllers;

public class MovieGenericController : Controller
{
    private readonly IMoviesGenericService _movieService;

    public MovieGenericController(IMoviesGenericService _movieService)
    {
        this._movieService = _movieService;
    }
    // GET
    public async Task<IActionResult> Index()
    {
        var c = await _movieService.GetAllMoviesAsync();
        
        return View(c);
    }
}