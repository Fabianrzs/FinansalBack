using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure;

namespace Aplication.Interface
{
    public interface IService<TEntity> where  TEntity : class
    {
        Task Add(TEntity entity);
        Task Edit(TEntity entity);
        Task Delete(TEntity entity);
        Task<IEnumerable<TEntity>> Getall();
        Task<TEntity> GetById(int id);
    }
}
