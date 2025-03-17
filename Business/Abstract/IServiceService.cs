using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IServiceService
    {
        void ServiceInsert(Service service);
        void ServiceUpdate(Service service);
        void ServiceDelete(Service service);
        List<Service> ServiceGetAll();
        Service ServiceGetById(int id);
    }
}
