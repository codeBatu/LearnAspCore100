using Batu.Entites.Concrete;
using Batu.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Repository.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly IContactRepository m_contactRepository;

        public ContactRepository(IContactRepository contactRepository)

        {
            m_contactRepository = contactRepository;
        }
        private Context m_item => new Context();
        public void Delete(ContactEntity t)
        {
            m_item.Remove(t);
            m_item.SaveChanges();
        }

        public ContactEntity GetById(int id)
        {
            return m_item.Set<ContactEntity>().Find(id);
        }

        public IEnumerable<ContactEntity> GetList()
        {
            return m_item.Set<ContactEntity>().ToList();
        }

        public void Insert(ContactEntity t)
        {
            m_item.Add(t);
            m_item.SaveChanges();
        }

        public void Update(ContactEntity t)
        {
            m_item.Update(t);
        }
    }
}
