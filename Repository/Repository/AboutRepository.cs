using Batu.Entites.Concrete;
using Batu.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Repository.Repository
{
    public class AboutRepository : IAboutRepository
    {
        private readonly IAboutRepository  m_aboutRepository;

        public AboutRepository(IAboutRepository aboutRepository)
        {
            m_aboutRepository = aboutRepository;
        }
        public AboutRepository():base()
        {

        }
        private static Context m_item => new ();
        public void Delete(About t)
        {
           m_item.Remove(t);
           m_item.SaveChanges();
        }
        public About GetById(int id)
        {
        return m_item.Set<About>().Find(id);  
        }

        public IEnumerable<About> GetList()
        {
            return m_item.Set<About>().ToList();
        }

        public void Insert(About t)
        {
            m_item.Add(t);
            m_item.SaveChanges();
        }
        
        public void Update(About t)
        {
            m_item.Update(t);
        }
    }
}
