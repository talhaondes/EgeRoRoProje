using Business.Concrete;
using Data.EF;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default
{
    public class _Fleet : ViewComponent
    {
        FleetManager fleetman = new FleetManager(new EfFleetDal());
        public IViewComponentResult Invoke()
        {
            var getir = fleetman.FleetGetAll();
            return View(getir);

        }
    }
}
