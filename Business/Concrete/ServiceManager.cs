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
    public class ServiceManager : IServiceService
    {
        IServiceDal _servicedal;

        public ServiceManager(IServiceDal servicedal)
        {
            _servicedal = servicedal;
        }

        public void ServiceDelete(Service service)
        {
            _servicedal.Delete(service);
        }

        public List<Service> ServiceGetAll()
        {
            return _servicedal.GetAll();
        }

        public Service ServiceGetById(int id)
        {
            return _servicedal.GetById(id);
        }

        public void ServiceInsert(Service service)
        {
            _servicedal.Insert(service);
        }

        public void ServiceUpdate(Service service)
        {
            _servicedal.Update(service);
        }
    }
}
