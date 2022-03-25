using Batu.Entites.Concrete;
using Batu.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Repository.Repository
{
   public class PortfolioRepo : IPortfolioRepo
    {
        private readonly IPortfolioRepo m_PortfolioRepo;
        public PortfolioRepo(IPortfolioRepo portfolioRepo)
        {
            m_PortfolioRepo = portfolioRepo;
        }
        public PortfolioRepo()
        {

        }
        private Context m_item => new Context();
        public void Delete(PortfolioEntity t)
        {

            m_item.Remove(t);
            m_item.SaveChanges();
        }

        public PortfolioEntity GetById(int id)
        {
            return m_item.Set<PortfolioEntity>().Find(id);
        }

        public IEnumerable<PortfolioEntity> GetList()
        {
            return m_item.Set<PortfolioEntity>().ToList();
        }

        public void Insert(PortfolioEntity t)
        {
            m_item.Add(t);
            m_item.SaveChanges();
        }
        public void Update(PortfolioEntity t)
        {
            m_item.Update(t);
        }
    }
}
