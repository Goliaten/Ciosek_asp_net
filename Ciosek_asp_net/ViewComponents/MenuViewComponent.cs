using Ciosek_asp_net.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Ciosek_asp_net.Views.Shared.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        FilmyContext db;

        public MenuViewComponent(FilmyContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("_Menu", db.Kategorie.ToList()));
        }

    }
}
