using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcCo.StdMng.Repositories.Contracts
{
    public interface IRepository<T> where T : class
    {
        bool Create(T obj);
        bool Delete(T obj);
        T Find(Expression<Func<T, bool>> predicate);
        List<T> FindList(Expression<Func<T, bool>> predicate);
        List<T> GetAll();
        bool Save();
        bool Update(T obj);

    }
}
