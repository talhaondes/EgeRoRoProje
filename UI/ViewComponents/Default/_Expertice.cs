using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default
{
    public class _Expertice : ViewComponent
    {
        private readonly IExperticeService _experticeService;

        public _Expertice(IExperticeService experticeService)
        {
            _experticeService = experticeService;
        }

        public IViewComponentResult Invoke()
        {
            var getir = _experticeService.ExperticeGetAll();
            return View(getir);
        }
    }
}
