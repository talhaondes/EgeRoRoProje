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
    public class GalleryService : IGalleryService
    {
        IGalleryDal _galleryDal;

        public GalleryService(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public void GalleryDelete(Gallery gallery)
        {
            _galleryDal.Delete(gallery);
        }

        public List<Gallery> GalleryGetAll()
        {
            return _galleryDal.GetAll();
        }

        public Gallery GalleryGetById(int id)
        {
            return _galleryDal.GetById(id);
        }

        public void GalleryInsert(Gallery gallery)
        {
            _galleryDal.Insert(gallery);
        }

        public void GalleryUpdate(Gallery gallery)
        {
            _galleryDal.Update(gallery);
        }
    }
}
