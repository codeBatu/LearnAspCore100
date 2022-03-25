using Batu.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Batu.Repository.Concrete;
namespace Batu.Repository.Repository
{
   public class SocialMediaRepo : ISocialMediaRepo
    {
        private readonly ISocialMediaRepo m_ISocialMediaRepo;
        public SocialMediaRepo(ISocialMediaRepo socialMediaRepo)
        {
            m_ISocialMediaRepo = socialMediaRepo;
        }
        public SocialMediaRepo():base()
        {

        }

        private Context m_item => new Context();
        public void Delete(SocialMediaEntity t)
        {
            m_item.Remove(t);
            m_item.SaveChanges();
        }

        public SocialMediaEntity GetById(int id)
        {
            return m_item.Set<SocialMediaEntity>().Find(id);
        }

        public IEnumerable<SocialMediaEntity> GetList()
        {
            return m_item.Set<SocialMediaEntity>().ToList();
        }

        public void Insert(SocialMediaEntity t)
        {
            m_item.Add(t);
            m_item.SaveChanges();
        }

        public void Update(SocialMediaEntity t)
        {
            m_item.Update(t);
        }
    }
}
