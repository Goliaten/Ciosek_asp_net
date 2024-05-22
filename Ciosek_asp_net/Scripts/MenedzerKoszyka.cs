using Ciosek_asp_net.DAL;
using Ciosek_asp_net.Helpers;
using Ciosek_asp_net.Models;

namespace Ciosek_asp_net.Nowy_folder
{
    public static class MenedzerKoszyka
    {
        public static int UsunZKoszyka(ISession session, int id)
        {
            var koszyk = (List<ElementKoszyka>)PobierzKoszyk(session);

            var usuwanyFilm = koszyk.Find(f => f.film.Id == id);
            int ilosc = 0;

            if (usuwanyFilm == null)
            {
                return ilosc;
            }

            if(usuwanyFilm.ilosc > 1)
            {
                usuwanyFilm.ilosc--;
                ilosc = usuwanyFilm.ilosc;
            }
            else
            {
                koszyk.Remove(usuwanyFilm);
            }
            
            SessionHelper.SetObjectAsJson(session, Consts.KluczSesji, koszyk);
            return ilosc;
        }

        private static List<ElementKoszyka>PobierzKoszyk(ISession session)
        {
            List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(session, Consts.KluczSesji);

            if (koszyk == null)
            {
                koszyk = new List<ElementKoszyka>();
            }
            return koszyk;
        }

        public static void DodajDoKoszyka(ISession session, FilmyContext db, int filmId)
        {
            var koszyk = PobierzKoszyk(session);
            var szukanyFilm = koszyk.Find(i => i.film.Id == filmId);

            if (szukanyFilm != null)
            {
                szukanyFilm.ilosc++;
            }
            else
            {
                var filmZBazy = db.Filmy.Where(i => i.Id == filmId).FirstOrDefault();

                if (filmZBazy != null) { 
                    var elementKoszyka= new ElementKoszyka() { ilosc = 1, wartosc = filmZBazy.Cena, film = filmZBazy };
                    koszyk.Add(szukanyFilm);
                }
            }

            SessionHelper.SetObjectAsJson(session, Consts.KluczSesji, koszyk);
        }

        public static int IloscElemKoszyka(ISession session)
        {
            var koszyk = PobierzKoszyk(session);
            return koszyk.Sum(i => i.ilosc);
        }
        public static decimal WartoscElemKoszyka(ISession session)
        {
            var koszyk = PobierzKoszyk(session);
            return koszyk.Sum(f => f.film.Cena * f.ilosc);
        }
    }
}


