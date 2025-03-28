using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default
{
    public class _Fleet : ViewComponent
    {
        private readonly IFleetService _fleetService;

        public _Fleet(IFleetService fleetService)
        {
            _fleetService = fleetService;
        }

        public IViewComponentResult Invoke()
        {
            var getir = _fleetService.FleetGetAll();
            return View(getir);
        }
    }
}
