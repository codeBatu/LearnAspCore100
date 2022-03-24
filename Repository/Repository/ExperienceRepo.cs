using Batu.Entites.Concrete;
using Batu.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Repository.Repository
{
  public  class ExperienceRepo : IExperienceRepo
    {
        private readonly IExperienceRepo m_experienceRepo;
        public ExperienceRepo(IExperienceRepo experienceRepo)
        {
            m_experienceRepo = experienceRepo;
        }
        private Context m_item => new Context();
        public void Delete(ExperienceEntity t)
        {
            m_item.Remove(t);
            m_item.SaveChanges();
        }

        public ExperienceEntity GetById(int id)
        {
            return m_item.Set<ExperienceEntity>().Find(id);
        }

        public IEnumerable<ExperienceEntity> GetList()
        {
            return m_item.Set<ExperienceEntity>().ToList();
        }

        public void Insert(ExperienceEntity t)
        {
            m_item.Add(t);
            m_item.SaveChanges();
        }

        public void Update(ExperienceEntity t)
        {
            m_item.Update(t);
        }
    }
}
