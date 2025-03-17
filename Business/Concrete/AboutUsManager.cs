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
    public class AboutUsManager : IAboutUsService
    {
        IAboutUsDal _aboutdal;

        public AboutUsManager(IAboutUsDal aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public void AboutUsDelete(AboutUs aboutUs)
        {
            _aboutdal.Delete(aboutUs);
        }

        public List<AboutUs> AboutUsGetAll()
        {
            return _aboutdal.GetAll();
        }

        public AboutUs AboutUsGetById(int id)
        {
            return _aboutdal.GetById(id);
        }

        public void AboutUsInsert(AboutUs aboutUs)
        {
            _aboutdal.Insert(aboutUs);
        }

        public void AboutUsUpdate(AboutUs aboutUs)
        {
            _aboutdal.Update(aboutUs);
        }
    }
}
