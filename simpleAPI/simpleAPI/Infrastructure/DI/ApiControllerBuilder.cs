using System;
using System.Collections.Generic;
using System.Web.Http.Dispatcher;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Net.Http;
using simpleAPI.Controllers;
using simpleAPI.Domain.Concrete;

namespace simpleAPI.Infrastructure.DI
{
    public class ApiControllerBuilder : IHttpControllerActivator
    {
        public IHttpController Create(HttpRequestMessage requestMessage, HttpControllerDescriptor controllerDescriptor, Type controllerType) 
        {
            if(controllerType == typeof(MoviesController)){
                return new MoviesController(new EfMovieRepository());
            }

            return null;
        }
    }
}