using Business.Concrete;
using Data.EF;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default
{
    public class _Expertice:ViewComponent
    {
        ExperticeManager experticeManager = new ExperticeManager(new EfExperticeDal());
        public IViewComponentResult Invoke()
        {
            var getir = experticeManager.ExperticeGetAll();
            return View(getir);
        }
    }
}
