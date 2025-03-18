using Business.Concrete;
using Data.EF;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default
{
    public class _AboutUs:ViewComponent
    {
        AboutUsManager aboutman = new AboutUsManager(new EfAboutUsDal());
        public IViewComponentResult Invoke()
        {
            var getir = aboutman.AboutUsGetAll();
            return View(getir);
        }
    }
}
