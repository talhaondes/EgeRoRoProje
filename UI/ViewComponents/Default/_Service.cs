using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default
{
    public class _Service : ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _Service(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var getir = _serviceService.ServiceGetAll();
            return View(getir);
        }
    }
}
