using System.Collections.Generic;
using SysDente.Entities;

namespace SysDente.Repositories
{
    public interface IRepositoryBase<T> where T : class, IEntity
    {
        void Save();
        IEnumerable<T> GetAll();
        void Add(T entidade);
        T Find(int id);
        void Remove(int id);
        void Update(T entidade, int id);
    }
}
