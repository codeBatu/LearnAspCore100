using Batu.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Repository.Repository
{
    public class GenericRepository<Entity> : ICrudRepository<Entity, int> where Entity : class
    {
        public void Delete(Entity t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public Entity GetById(int id)
        {
            using var c = new Context();
            return c.Set<Entity>().Find(id);
        }

        public IEnumerable<Entity> GetList()
        {
            using var c = new Context();
            return c.Set<Entity>().ToList();
        }

        public void Insert(Entity t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Entity t)
        {
            using var c = new Context();
            c.Update(t);
        }
    }
}
