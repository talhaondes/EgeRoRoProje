using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IContactService
    {
        void ContactInsert(Contact contact);
        void ContactUpdate(Contact contact);
        void ContactDelete(Contact contact);
        List<Contact> ContactGetAll();
        Contact ContactGetById(int id);

    }
}
