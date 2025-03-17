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
    public class FleetService : IFleetService
    {
        IFleetDal _fleetdal;

        public FleetService(IFleetDal fleetdal)
        {
            _fleetdal = fleetdal;
        }

        public void FleetDelete(Fleet fleet)
        {
            _fleetdal.Delete(fleet);
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
