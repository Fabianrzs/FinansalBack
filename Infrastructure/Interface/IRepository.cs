using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface IRepository<TEntity> where  TEntity : class
    {
        Task<IEnumerable<TEntity>> Getall();
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetBy(Expression filter = null, string includesPropieties = "",
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> ordenarPor = null);
        IQueryable<TEntity> GetByQueryable(Expression<Func<TEntity, bool>> filter = null, string includesPropieties = "",
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> ordenarPor = null);
        Task Add(TEntity entity);
        Task Edit(TEntity entity);
        Task Delete(TEntity entity);
        Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> predicado);
    }
}
