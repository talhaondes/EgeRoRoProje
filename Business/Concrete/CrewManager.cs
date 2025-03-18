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
    public class CrewManager : ICrewService
    {
        ICrewDal _ıcrewdal;

        public CrewManager(ICrewDal ıcrewdal)
        {
            _ıcrewdal = ıcrewdal;
        }

        public void CrewDelete(Crew crew)
        {
            _ıcrewdal.Delete(crew);
        }

        public List<Crew> CrewGetAll()
        {
            return _ıcrewdal.GetAll();  
        }

        public Crew CrewGetById(int id)
        {
            return _ıcrewdal.GetById(id);
        }

        public void CrewInsert(Crew crew)
        {
            _ıcrewdal.Insert(crew); 
        }

        public void CrewUpdate(Crew crew)
        {
            _ıcrewdal.Update(crew); 
        }
    }
}
