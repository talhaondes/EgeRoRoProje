using Business.Concrete;
using Data.EF;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class AboutController : Controller
    {
        AboutUsManager _aboutUsManager = new AboutUsManager(new EfAboutUsDal());

        public IActionResult Index()
        {
            var getir = _aboutUsManager.AboutUsGetAll();
            return View(getir);
        }
    }
}
