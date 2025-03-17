using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICrewService
    {
        void CrewInsert(Crew crew);
        void CrewUpdate(Crew crew);
        void CrewDelete(Crew crew);
        List<Crew> CrewGetAll();
        Crew CrewGetById(int id);
    }
}
