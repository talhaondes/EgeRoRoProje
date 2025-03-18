using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IFleetService
    {
        void FleetInsert(Fleet fleet);
        void FleetUpdate(Fleet fleet);
        void FleetDelete(Fleet fleet);
        List<Fleet> FleetGetAll();
        Fleet FleetGetById(int id);
        Fleet FleetGetByName(string name);


    }
}
