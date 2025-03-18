using Business.Concrete;
using Data.EF;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.ViewComponents.Default
{
    public class _LayLayOut : ViewComponent
    {
        ServiceManager _serviceManager = new ServiceManager(new EfServiceDal());
        FleetManager _fleet = new FleetManager(new EfFleetDal());


        public IViewComponentResult Invoke()
        {
            var services = _serviceManager.ServiceGetAll();
            var fleets = _fleet.FleetGetAll();

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
