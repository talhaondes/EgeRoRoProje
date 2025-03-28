using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using UI.Models;
using System.Linq;

namespace UI.ViewComponents.Default
{
    public class _LayLayOut : ViewComponent
    {
        private readonly IServiceService _serviceService;
        private readonly IFleetService _fleetService;

        public _LayLayOut(IServiceService serviceService, IFleetService fleetService)
        {
            _serviceService = serviceService;
            _fleetService = fleetService;
        }

        public IViewComponentResult Invoke()
        {
            var services = _serviceService.ServiceGetAll();
            var fleets = _fleetService.FleetGetAll();

            var dropDownList = services.Select(service => new DropDownModel
            {
                serviceId = service.ServiceId,
                serviceName = service.HizmetAdi,
            }).ToList();

            var dropDownListt = fleets.Select(fleet => new DropDownModel
            {
                fleettId = fleet.FleetId,
                FiloBaslik = fleet.FiloBaslik
            }).ToList();

            var model = new { Services = dropDownList, Fleets = dropDownListt };
            return View(model);
        }
    }
}
