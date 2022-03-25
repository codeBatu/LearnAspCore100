using Batu.Entites.Concrete;
using Batu.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Repository.Repository
{
   public class ServiceRepo : IServiceRepo
    {
        private readonly IServiceRepo m_serviceRepo;
        public ServiceRepo(IServiceRepo serviceRepo)
        {
            m_serviceRepo = serviceRepo;
        }
        public ServiceRepo():base  ()
        {

        }
        private  static Context m_item =>new();
        public void Delete(ServiceEntity t)
        {
          m_item.Remove(t);
        }

        public ServiceEntity GetById(int id)
        {
            return m_item.Set<ServiceEntity>().Find(id);
        }

        public IEnumerable<ServiceEntity> GetList()
        {
            return m_item.Set<ServiceEntity>().ToList();
        }

        public void Insert(ServiceEntity t)
        {
            m_item.Add(t);
            m_item.SaveChanges();
        }

        public void Update(ServiceEntity t)
        {
            m_item.Update(t);
        }
    }
}
