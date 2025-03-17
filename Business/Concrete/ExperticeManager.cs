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
    public class ExperticeManager : IExperticeService
    {
        IExperticeDal _experticedal;

        public ExperticeManager(IExperticeDal experticedal)
        {
            _experticedal = experticedal;
        }

        public void ExperticeDelete(Expertice expertice)
        {
            _experticedal.Delete(expertice);
        }

        public List<Expertice> ExperticeGetAll()
        {
            return _experticedal.GetAll();
        }

        public Expertice ExperticeGetById(int id)
        {
            return _experticedal.GetById(id);
        }

        public void ExperticeInsert(Expertice expertice)
        {
            _experticedal.Insert(expertice);
        }

        public void ExperticeUpdate(Expertice expertice)
        {
            _experticedal.Update(expertice);
        }
    }
}
