using System;
using System.Collections.Generic;
using System.Net;
using Aplication.Interface;

namespace Aplication
{
    public abstract class RequestBase
    {
        public string Message { get; set; }
        public bool Error { get; set; }
        public HttpStatusCode Code { get; set; }
    }

    public class Request<TEntity> : RequestBase, IRequest<TEntity>
    {
        public TEntity Dates { get; set; }
        public TEntity Data { get; set; }
        
        public static Request<TEntity> CrearRespuestaExitosa(TEntity dates, HttpStatusCode code)
        {
            return new Request<TEntity>
            {
                Code = code,
                Dates = dates,
                Error = false,
            };
        }

        public static Request<TEntity> CrearRespuestaFallida(HttpStatusCode code, string mensaje)
        {
            return new Request<TEntity>
            {
                Message = mensaje,
                Code = code,
                Error = true,
            };
        }

    }
    
}