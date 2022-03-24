using Batu.Entites.Concrete;
using Batu.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Repository.Repository
{
    public class SkillRepo : ISkillRepo
    {
        private readonly ISkillRepo m_skillRepo;

        public SkillRepo(ISkillRepo skillRepo)
        {
            m_skillRepo = skillRepo;

        }
        private Context m_item => new Context();
        public void Delete(SkillEntity t)
        {
            m_item.Remove(t);
            m_item.SaveChanges();
        }

        public SkillEntity GetById(int id)
        {
            return m_item.Set<SkillEntity>().Find(id);
        }

        public IEnumerable<SkillEntity> GetList()
        {
            return m_item.Set<SkillEntity>().ToList();
        }

        public void Insert(SkillEntity t)
        {
            m_item.Add(t);
            m_item.SaveChanges();
        }

        public void Update(SkillEntity t)
        {
            m_item.Update(t);
        }
    }
}
