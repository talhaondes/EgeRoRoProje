using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IAboutUsService
    {
        void AboutUsInsert(AboutUs aboutUs);
        void AboutUsUpdate(AboutUs aboutUs);
        void AboutUsDelete(AboutUs aboutUs);
        List<AboutUs> AboutUsGetAll();
        AboutUs AboutUsGetById(int id);
    }
}
