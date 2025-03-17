using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Abstract;
using Data.Repository;
using Entity.Concrete;

namespace Data.EF
{
    public class EfGalleryDal : GenericRepository<Gallery>, IGalleryDal
    {
       
    }
}
