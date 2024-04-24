using Ciosek_asp_net.DAL;
using Ciosek_asp_net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Ciosek_asp_net.Controllers
{
    public class FilmyController : Controller
    {
        FilmyContext db;
        IWebHostEnvironment hostEnvironment;


        public FilmyController(FilmyContext db, IWebHostEnvironment hostEnvironment)
        {
            this.db = db;
            this.hostEnvironment = hostEnvironment;
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

        [HttpGet]
        public IActionResult DodajFilm()
        {
            DodawanieFilmow dodaj = new DodawanieFilmow();

            var kategorie = db.Kategorie.ToList();
            dodaj.kategorie = kategorie;

            return View(dodaj);
        }

        public IActionResult DodajFilm(DodawanieFilmow obj)
        {
            obj.film.Data_dodania = DateTime.Now;

            var pathPlakat = Path.Combine(hostEnvironment.WebRootPath, "assets");
            var nazwaPlakatuUnikat = Guid.NewGuid() + "_" + obj.plakat.FileName;
            var sciezkaDoPlakatu = Path.Combine(pathPlakat, nazwaPlakatuUnikat);
            obj.plakat.CopyTo(new FileStream(sciezkaDoPlakatu, FileMode.Create));

            obj.film.nazwaPlakatu = nazwaPlakatuUnikat;

            db.Filmy.Add(obj.film);

            db.SaveChanges();

            return RedirectToAction("Szczegoly", new { idFilmu = obj.film.Id });
            //return View("DodajFilm");
        }

    }
}
