using Batu.Entites.Concrete;
using Batu.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Repository.Repository
{
    public class MessageRepo : IMessageRepo
    {
        private readonly IMessageRepo m_mmesageRepo;
        public MessageRepo(IMessageRepo messageRepo)
        {
            m_mmesageRepo=messageRepo;
        }
        public MessageRepo()
        {

        }
        private Context m_item => new Context();
        public void Delete(MessageEntity t)
        {
            m_item.Remove(t);
            m_item.SaveChanges();
         
        }

        public MessageEntity GetById(int id)
        {
            return m_item.Set<MessageEntity>().Find(id);
        }

        public IEnumerable<MessageEntity> GetList()
        {
            return m_item.Set<MessageEntity>().ToList();
        }

        public void Insert(MessageEntity t)
        {
            m_item.Add(t);
            m_item.SaveChanges();
        }

        public void Update(MessageEntity t)
        {
            m_item.Update(t);
        }
    }
}
