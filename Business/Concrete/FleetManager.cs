using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Data.Abstract;
using Data.EF;
using Entity.Concrete;

namespace Business.Concrete
{
    public class FleetManager : IFleetService
    {
        IFleetDal _fleetdal;


        public FleetManager(IFleetDal fleetdal)
        {
            _fleetdal = fleetdal;
        }

        public void FleetDelete(Fleet fleet)
        {
            _fleetdal.Delete(fleet);
        }

        public List<Fleet> FleetGetAll()
        {
            return _fleetdal.GetAll();
        }

        public Fleet FleetGetById(int id)
        {
            return _fleetdal.Get(f => f.FleetId == id);
        }


        public Fleet FleetGetByName(string name)
        {
            return _fleetdal.Get(x => x.FiloBaslik == name);  
        }


        public void FleetInsert(Fleet fleet)
        {
            _fleetdal.Insert(fleet);
        }

        public void FleetUpdate(Fleet fleet)
        {
            _fleetdal.Update(fleet);
        }
    }
}
