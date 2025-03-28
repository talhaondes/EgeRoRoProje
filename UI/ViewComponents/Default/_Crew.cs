using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Default
{
    public class _Crew : ViewComponent
    {
        private readonly ICrewService _crewService;

        public _Crew(ICrewService crewService)
        {
            _crewService = crewService;
        }

        public IViewComponentResult Invoke()
        {
            var getir = _crewService.CrewGetAll();
            return View(getir);
        }
    }
}
