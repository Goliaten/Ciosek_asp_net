using Ciosek_asp_net.DAL;
using Ciosek_asp_net.Helpers;
using Ciosek_asp_net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace Ciosek_asp_net.Controllers
{
    public class KoszykController : Controller
    {
        FilmyContext db;

        public KoszykController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KluczSesji);
            if (koszyk != null)
            {
                ViewBag.CalaSuma = koszyk.Sum(f => f.film.Cena * f.ilosc);
            }
            else
            {
                ViewBag.CalaSuma = 0;
            }
            return View(koszyk);
        }

        [Route("Kup/{Id}")]
        public IActionResult Kup(int id)
        {
            Film film = db.Filmy.Find(id);

            if (SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KluczSesji) == default(List<ElementKoszyka>))
            {
                // brak koszyka
                List<ElementKoszyka> koszyk = new List<ElementKoszyka>
                {
                    new ElementKoszyka{film=film, ilosc=1, wartosc=film.Cena}
                };
                SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KluczSesji, koszyk);
            }
            else
            {
                // jest koszyk
                List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KluczSesji);
                int ind = koszyk.FindIndex(f => f.film == film);
                if (ind >= 0)
                {
                    //jest film w koszyku
                    koszyk[ind].ilosc += 1;
                }
                else
                {
                    //nie ma filmu w koszyku
                    koszyk.Add( new ElementKoszyka { film = film, ilosc = 1, wartosc = film.Cena });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KluczSesji, koszyk);
            }

            return View();
        }
    }
}
