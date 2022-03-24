using Batu.Entites.Concrete;
using Batu.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Repository.Repository
{
    public class MainPageRepo : IMainPage
    {
        private readonly IMainPage m_mainPage;
        public MainPageRepo(IMainPage mainPage)
        {
            m_mainPage = mainPage;

        }
        public void Delete(MainPage t)
        {
            using var item = new Context();
            item.Remove(t);
            item.SaveChanges();
        }

        public MainPage GetById(int id)
        {
            using var item = new Context();
            return item.Set<MainPage>().Find(id);
        }

        public IEnumerable<MainPage> GetList()
        {
            using var item = new Context();
            return item.Set<MainPage>().ToList();
        }

        public void Insert(MainPage t)
        {
            using var item = new Context();
            item.Add(t);
            item.SaveChanges();
        }

        public void Update(MainPage t)
        {
            using var item = new Context();
            item.Update(t);
        }
    }
}
