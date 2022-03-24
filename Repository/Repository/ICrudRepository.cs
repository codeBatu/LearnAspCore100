using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Repository.Repository
{
  public  interface ICrudRepository<T,ID> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        IEnumerable<T> GetList();
        T GetById(ID id);

    }
}
