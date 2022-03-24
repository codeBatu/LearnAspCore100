using Batu.Entites.Concrete;
using Batu.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Repository.Repository
{
    class TestimonialRepo : ITestimonialRepo
    {
     readonly private   ITestimonialRepo m_ıTestimonialRepo;
        public TestimonialRepo(ITestimonialRepo testimonialRepo)
        {
            m_ıTestimonialRepo = testimonialRepo;
        }
        private Context m_item => new Context();
        public void Delete(TestimonialEntity t)
        {
            m_item.Remove(t);
            m_item.SaveChanges();
        }

        public TestimonialEntity GetById(int id)
        {
            return m_item.Set<TestimonialEntity>().Find(id);
        }

        public IEnumerable<TestimonialEntity> GetList()
        {
            return m_item.Set<TestimonialEntity>().ToList();
        }

        public void Insert(TestimonialEntity t)
        {
            m_item.Add(t);
            m_item.SaveChanges();
        }

        public void Update(TestimonialEntity t)
        {
            m_item.Update(t);
        }
    }
}
