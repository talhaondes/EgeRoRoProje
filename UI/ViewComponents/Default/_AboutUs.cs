using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default
{
    public class _AboutUs : ViewComponent
    {
        private readonly IAboutUsService _aboutUsService;

        public _AboutUs(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        public IViewComponentResult Invoke()
        {
            var getir = _aboutUsService.AboutUsGetAll();
            return View(getir);
        }
    }
}
