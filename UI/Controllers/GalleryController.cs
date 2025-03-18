using Business.Concrete;
using Data.EF;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class GalleryController : Controller
    {
        GalleryManager gm = new GalleryManager(new EfGalleryDal());
        public IActionResult Index()
        {
            var gelsin = gm.GalleryGetAll();
            return View(gelsin);
        }
    }
}
