using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IGalleryService _galleryService;

        public GalleryController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public IActionResult Index()
        {
            var gelsin = _galleryService.GalleryGetAll();
            return View(gelsin);
        }

        [HttpPost]
        [Authorize] // Sadece giriş yapmış kullanıcılar güncelleme yapabilsin.
        public IActionResult UpdateGallery(Gallery gallery)
        {
            var existingGallery = _galleryService.GalleryGetById(gallery.GalleryId);
            if (existingGallery != null)
            {
                // Formdan gelen verilerle güncelleme yapılıyor.
                existingGallery.galeriFoto = gallery.galeriFoto;
                // Eğer başka alanlar varsa burada güncelleyin.

                _galleryService.GalleryUpdate(existingGallery);
            }

            return RedirectToAction("Index");
        }
    }
}
