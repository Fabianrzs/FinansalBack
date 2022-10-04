using System.Net;

namespace Aplication.Interface
{
    public interface IRequest<TEntity>
    {
        public HttpStatusCode Code { get; set; }
        TEntity Data { get; set; }
    }
}