using SysDente.Entities;
using SysDente.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysDente.Services.Impl
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : class, IEntity, new()
    {
        private readonly IRepositoryBase<T> _repository;
       
        protected ServiceBase(IRepositoryBase<T> repository)
        {
            this._repository = repository;
        }

        public virtual T Find(int id)
        {
            return _repository.Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }


        public virtual void Add(T entity)
        {
            try
            {
                _repository.Add(entity);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public virtual IEnumerable<T> CreateAll(List<T> entities)
        {
            foreach (T entitiy in entities)
            {
                try
                {
                   _repository.Add(entitiy);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            try
            {
                _repository.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return entities.AsQueryable();
        }

        


        public virtual void Update(T entity, int id)
        {
            try
            {
                _repository.Update(entity, id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        
        public virtual void Remove(int id)
        {
            try
            {
                _repository.Remove(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}