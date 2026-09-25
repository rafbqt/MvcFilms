using Microsoft.AspNetCore.Mvc;
using MvcFilms.Models;

namespace MvcFilms.Controllers;

public class FilmsController : Controller
{
    private static readonly List<Film> films = new()
{
    new Film { Id = 1, Titre = "Alien", Annee = 1979, Realisateur = "Ridley Scott" },
    new Film { Id = 2, Titre = "Dune", Annee = 2021, Realisateur = "Denis Villeneuve" },
    new Film { Id = 3, Titre = "Interstellar", Annee = 2014, Realisateur = "Christopher Nolan" },
    new Film { Id = 4, Titre = "Inception", Annee = 2010, Realisateur = "Christopher Nolan" }
};

    public IActionResult Index()
    {
        return View(films);
    }
    public IActionResult Details(int? id)
{
    var film = films.FirstOrDefault(f => f.Id == id);

    if (film == null)
    {
        return NotFound();
    }

    return View(film);
}
}