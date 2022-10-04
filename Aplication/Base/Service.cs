using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Aplication.Interface;
using Infrastructure;

namespace Aplication
{
    public class Service<TEntity> : IService<TEntity> where TEntity: class
    {
        public UnitOfWork UnitOfWork { get; set; }
        public Task Add(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> Getall()
        {
            throw new System.NotImplementedException();
        }

        public Task<TEntity> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}