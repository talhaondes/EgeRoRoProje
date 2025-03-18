using Business.Concrete;
using Data.EF;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            var gel = serviceManager.ServiceGetAll();
            return View(gel);
        }
        public IActionResult Detail(int id)
        {
            var services = serviceManager.ServiceGetAll(); // Tüm hizmetleri çek
            var selectedService = serviceManager.ServiceGetById(id);
            var model = new ServiceDetailViewModel
            {
                AllServices = services,
                SelectedService = selectedService
            };

            return View(model);
        }
    }
}
