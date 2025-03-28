using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        public IActionResult Index()
        {
            var getir = _aboutUsService.AboutUsGetAll();
            return View(getir);
        }

        [HttpPost]
        [Authorize] // Sadece giriş yapmış kullanıcılar güncelleme yapabilir.
        public IActionResult UpdateAbout(AboutUs model)
        {
            var about = _aboutUsService.AboutUsGetById(model.AboutUsId);
            if (about != null)
            {
                // Formdan gelen verilerle güncelle
                about.HakkimizdaBaslik1 = model.HakkimizdaBaslik1;
                about.HakkimizdaAciklama1 = model.HakkimizdaAciklama1;
                about.HakkimizdaBaslik2 = model.HakkimizdaBaslik2;
                about.HakkimizdaAciklama2 = model.HakkimizdaAciklama2;
                about.HakkimizdaFoto = model.HakkimizdaFoto;
                about.anasayfaFoto = model.anasayfaFoto;
                about.koseFoto1 = model.koseFoto1;
                about.koseFoto2 = model.koseFoto2;

                _aboutUsService.AboutUsUpdate(about);
            }

            return RedirectToAction("Index");
        }
    }
}
