using Ciosek_asp_net.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ciosek_asp_net.ViewComponents
{
    public class FilmyKategoriiViewComponent : ViewComponent
    {
        FilmyContext db;

        public FilmyKategoriiViewComponent(FilmyContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(string nazwaKategorii)
        {
            var model = db.Kategorie
                .Include("Filmy")
                .Where(k => k.Nazwa.ToLower() == nazwaKategorii.ToLower())
                .Single()
                .Filmy.ToList();
            return await Task.FromResult((IViewComponentResult)View("_FilmyKategorii", model));
        }
    }
}
