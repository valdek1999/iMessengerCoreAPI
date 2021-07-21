using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> All { get; }

        int Count { get; }
        TEntity Add(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);

        TEntity FindById(int Id);

        IEnumerable<TEntity> FindAll(Func<TEntity, bool> predicate);
    }
}
