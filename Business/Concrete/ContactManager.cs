using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Data.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactdal;

        public ContactManager(IContactDal contactdal)
        {
            _contactdal = contactdal;
        }

        public void ContactDelete(Contact contact)
        {
            _contactdal.Delete(contact);    
        }

        public List<Contact> ContactGetAll()
        {
            return _contactdal.GetAll();
        }

        public Contact ContactGetById(int id)
        {
            return _contactdal.GetById(id);
        }

        public void ContactInsert(Contact contact)
        {
            _contactdal.Insert(contact);    
        }

        public void ContactUpdate(Contact contact)
        {
           _contactdal.Update(contact); 
        }
    }
}
