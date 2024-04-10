using Ciosek_asp_net.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Ciosek_asp_net.Controllers
{
    public class FilmyController : Controller
    {
        FilmyContext db;

        public FilmyController(FilmyContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista(string nazwaKategorii)
        {
            var kategorie = db.Kategorie.Include("Filmy").Where(k => k.Nazwa.ToLower() == nazwaKategorii.ToLower()).Single();

            var filmy = kategorie.Filmy.ToList();

            ViewBag.Title = nazwaKategorii;

            return View(filmy);
        }
        public IActionResult Szczegoly(int idFilmu)
        {
            var kategoria = db.Kategorie.Find(db.Filmy.Find(idFilmu).KategoriaId);
            var film = db.Filmy.Find(idFilmu);
            return View(film);
        }
    }
}
