using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Abstract;
using Data.Concrete;

namespace Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        public void Delete(T entity)
        {
            using var db = new Context();
            db.Remove(entity);
            db.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var ctx = new Context();
            return ctx.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var db = new Context();
            return db.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            using var context = new Context();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Update(T entity)
        {
            using var context = new Context();
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
