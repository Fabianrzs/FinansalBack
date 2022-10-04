using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Infrastructure.Interface;

namespace Infrastructure
{
    public class Repository<TEntity> :  IRepository<TEntity> where TEntity: class
    {
        public Task<IEnumerable<TEntity>> Getall()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetBy(Expression filter = null, string includesPropieties = "", Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> ordenarPor = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetByQueryable(Expression<Func<TEntity, bool>> filter = null, string includesPropieties = "", Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> ordenarPor = null)
        {
            throw new NotImplementedException();
        }

        public Task Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Edit(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> predicado)
        {
            throw new NotImplementedException();
        }
    }
}