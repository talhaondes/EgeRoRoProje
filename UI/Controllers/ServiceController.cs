using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var services = _serviceService.ServiceGetAll();
            return View(services);
        }

        public IActionResult Detail(int id)
        {
            var services = _serviceService.ServiceGetAll();
            var selectedService = _serviceService.ServiceGetById(id);

            var model = new ServiceDetailViewModel
            {
                AllServices = services,
                SelectedService = selectedService
            };

            return View(model);
        }

        [HttpPost]
        [Authorize] // Yalnızca giriş yapmış kullanıcılar güncelleme yapabilsin.
        public IActionResult UpdateService(Service service)
        {
            var existingService = _serviceService.ServiceGetById(service.ServiceId);
            if (existingService != null)
            {
                // Formdan gelen verilerle güncelleme yapılıyor.
                existingService.HizmetAdi = service.HizmetAdi;
                existingService.HizmetFoto = service.HizmetFoto;
                existingService.serviceNo = service.serviceNo;
                // İhtiyacınıza göre diğer alanları da güncelleyin.

                _serviceService.ServiceUpdate(existingService);
            }

            return RedirectToAction("Index");
        }
    }
}
