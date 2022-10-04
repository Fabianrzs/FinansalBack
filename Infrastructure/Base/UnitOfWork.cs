using Infrastructure.Interface;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(AppContext _context) => Context = _context;
        public AppContext Context { get; set; }
        public void Dispose()
        {
            Context.Dispose();
        }
        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}