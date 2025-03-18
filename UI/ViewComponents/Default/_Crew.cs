using Business.Concrete;
using Data.EF;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default
{
    public class _Crew : ViewComponent
    {
        CrewManager cm = new CrewManager(new EfCrewDal());

        public IViewComponentResult Invoke()
        {
            var getir = cm.CrewGetAll();
            return View(getir);
        }
    }
}
