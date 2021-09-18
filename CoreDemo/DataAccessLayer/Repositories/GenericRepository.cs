using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        
        public void Add(T entity)
        {
            using (Context c=new Context())
            {
                c.Add(entity);
                c.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (Context c = new Context())
            {
                c.Remove(entity);
                c.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (Context c = new Context())
            {
                return  c.Set<T>().ToList();
                
            }
        }

        public T GetById(int id)
        {
            using (Context c = new Context())
            {
                return c.Set<T>().Find(id);

            }
        }

        public void Update(T entity)
        {
            using (Context c = new Context())
            {
                c.Update(entity);
                c.SaveChanges();
            }
        }
    }
}
