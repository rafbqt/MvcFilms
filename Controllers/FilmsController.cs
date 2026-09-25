using Microsoft.AspNetCore.Mvc;
using MvcFilms.Models;

namespace MvcFilms.Controllers;

public class FilmsController : Controller
{
    private static readonly List<Film> films = new()
    {
        new Film { Id = 1, Titre = "Alien", Annee = 1979 },
        new Film { Id = 2, Titre = "Dune", Annee = 2021 },
        new Film { Id = 3, Titre = "Interstellar", Annee = 2014 }
    };

    public IActionResult Index()
    {
        return View(films);
    }
}