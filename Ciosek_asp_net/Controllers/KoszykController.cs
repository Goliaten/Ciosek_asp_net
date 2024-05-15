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
                ViewBag.IloscBilet = koszyk.Sum(f => f.ilosc);
            }
            else
            {
                ViewBag.CalaSuma = 0;
                ViewBag.IloscBilet = 0;
            }
            return View(koszyk);
        }

        [Route("Kup/{Id}")]
        public IActionResult Kup(int id)
        {
            //System.Diagnostics.Debug.WriteLine("-------------");
            Film film = db.Filmy.Find(id);

            if (SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KluczSesji) == default(List<ElementKoszyka>))
            {
                // brak koszyka
                List<ElementKoszyka> koszyk = new List<ElementKoszyka>
                {
                    new ElementKoszyka{film=film, ilosc=1, wartosc=film.Cena}
                };
                SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KluczSesji, koszyk);
                //System.Diagnostics.Debug.WriteLine("-------------A");
            }
            else
            {
                // jest koszyk
                List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KluczSesji);
                int ind = koszyk.FindIndex(f => f.film.Id == film.Id);
                //System.Diagnostics.Debug.WriteLine("-------------Index = " + ind);
                if (ind >= 0)
                {
                    //jest film w koszyku
                    koszyk[ind].ilosc += 1;
                    //System.Diagnostics.Debug.WriteLine("-------------B");
                }
                else
                {
                    //nie ma filmu w koszyku
                    koszyk.Add( new ElementKoszyka { film = film, ilosc = 1, wartosc = film.Cena });
                    //System.Diagnostics.Debug.WriteLine("-------------C");
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KluczSesji, koszyk);
            }

            return View();
        }

        [Route("Usun/{Id}")]
        public IActionResult Usun(int id)
        {
            // założenie, że koszyk istnieje i film jest w koszyku
            Film film = db.Filmy.Find(id);
            List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KluczSesji);
            int ind = koszyk.FindIndex(f => f.film.Id == film.Id);
            if (koszyk[ind].ilosc > 1)
            {
                koszyk[ind].ilosc -= 1;
            }
            else
            {
                koszyk.RemoveAt(ind);
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KluczSesji, koszyk);

            return RedirectToAction("Index");
        }

        public int PobierzIloscRzeczyZKoszyka()
        {
            List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KluczSesji);

            if (koszyk != null)
            {
                return koszyk.Sum(f => f.ilosc);
            }
            else
            {
                return 0;
            }
        }
        public int PobierzWartoscKoszyka()
        {
            List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KluczSesji);

            if (koszyk != null)
            {
                return (int)koszyk.Sum(f => f.film.Cena * f.ilosc);
            }
            else
            {
                return 0;
            }
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.CalaSuma = PobierzWartoscKoszyka();
            ViewBag.IloscBilet = PobierzIloscRzeczyZKoszyka();
            return await Task.FromResult((IViewComponentResult)View("_Menu", db.Kategorie.ToList()));
        }
    }
}
