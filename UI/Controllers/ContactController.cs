using Business.Concrete;
using Data.EF;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactdal());
        public IActionResult Index()
        {
            var getir = cm.ContactGetAll();
            return View(getir);
        }
    }
}
