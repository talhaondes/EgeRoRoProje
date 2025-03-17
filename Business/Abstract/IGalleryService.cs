using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IGalleryService
    {
        void GalleryInsert(Gallery gallery);
        void GalleryUpdate(Gallery gallery);
        void GalleryDelete(Gallery gallery);
        List<Gallery> GalleryGetAll();
        Gallery GalleryGetById(int id);
    }
}
