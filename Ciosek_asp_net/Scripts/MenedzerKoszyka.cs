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

        private static object PobierzKoszyk(ISession session)
        {
            List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(session, Consts.KluczSesji);

            if (koszyk != null)
            {
                return koszyk;
            }
            else
            {
                return new List<ElementKoszyka>();
            }
        }
    }
}
