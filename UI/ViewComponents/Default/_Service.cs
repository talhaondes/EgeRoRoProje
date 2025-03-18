
using Business.Concrete;
using Data.EF;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default

{
    public class _Service : ViewComponent
    {
        ServiceManager sm = new ServiceManager(new EfServiceDal());

        public IViewComponentResult Invoke()
        {
            var getir = sm.ServiceGetAll();
            return View(getir);
        }
    }
}
