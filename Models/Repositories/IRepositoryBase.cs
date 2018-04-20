using System.Collections.Generic;
using SysDente.Entities;

namespace SysDente.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T entidade);
        IEnumerable<T> GetAll();
        T Find(long id);
        void Remove(long id);
        void Update(T entidade);
    }
}
