using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var contacts = _contactService.ContactGetAll();
            return View(contacts);
        }

        [HttpPost]
        [Authorize]
        public IActionResult UpdateContact(Contact contact)
        {
            var existingContact = _contactService.ContactGetById(contact.ContactId);
            if (existingContact != null)
            {
                existingContact.iletisimBaslik = contact.iletisimBaslik;
                existingContact.Adress = contact.Adress;
                existingContact.Telefon = contact.Telefon;
                existingContact.Email = contact.Email;
                _contactService.ContactUpdate(existingContact);
            }
            return RedirectToAction("Index");
        }
    }
}
