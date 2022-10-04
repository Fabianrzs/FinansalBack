using System;
using System.ComponentModel;

namespace Infrastructure.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        public AppContext Context { get; set; }
        public void Commit();

    }
}