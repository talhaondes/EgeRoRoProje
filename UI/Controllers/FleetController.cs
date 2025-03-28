using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class FleetController : Controller
    {
        private readonly IFleetService _fleetService;

        public FleetController(IFleetService fleetService)
        {
            _fleetService = fleetService;
        }

        public IActionResult Index()
        {
            var fleets = _fleetService.FleetGetAll();
            return View(fleets);
        }

        public IActionResult Detail(int id)
        {
            var fleet = _fleetService.FleetGetById(id);
            return View(fleet);
        }

        [HttpPost]
        [Authorize] // Yalnızca giriş yapmış kullanıcılar güncelleme yapabilsin.
        public IActionResult UpdateFleet(Fleet fleet)
        {
            var existingFleet = _fleetService.FleetGetById(fleet.FleetId);
            if (existingFleet != null)
            {
                // Formdan gelen verilerle mevcut kaydı güncelle
                existingFleet.GemiAd = fleet.GemiAd;
                existingFleet.GemiFoto = fleet.GemiFoto;
                existingFleet.Gemino = fleet.Gemino;
                // Diğer alanları da ihtiyaca göre güncelleyebilirsiniz.

                _fleetService.FleetUpdate(existingFleet);
            }

            return RedirectToAction("Index");
        }
    }
}
