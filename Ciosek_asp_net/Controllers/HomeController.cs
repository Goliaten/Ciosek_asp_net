using Ciosek_asp_net.DAL;
using Ciosek_asp_net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ciosek_asp_net.Controllers
{
    public class HomeController : Controller
    {
        FilmyContext db;

        public HomeController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult StronaStatyczna(string nazwa) { return View(nazwa); }

        public IActionResult Index()
        {
            var kategorie = db.Kategorie.ToList();
            return View(kategorie);
        }

        public IActionResult Privacy() { return View(); }
        public IActionResult Kontakt() { return View(); }
        public IActionResult MetodyPlatnosci() { return View(); }
        public IActionResult Regulamin() { return View(); }
        public IActionResult ONas() { return View(); }
    }
}