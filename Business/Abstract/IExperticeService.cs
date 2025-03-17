using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IExperticeService
    {
        void ExperticeInsert(Expertice expertice);
        void ExperticeUpdate(Expertice expertice);
        void ExperticeDelete(Expertice expertice);
        List<Expertice> ExperticeGetAll();
        Expertice ExperticeGetById(int id);
    }
}
