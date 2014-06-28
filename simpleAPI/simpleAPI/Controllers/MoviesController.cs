using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using simpleAPI.Domain;
using simpleAPI.Domain.Abstract;

namespace simpleAPI.Controllers
{
    public class MoviesController : ApiController
    {
        private IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository) 
        {
            _movieRepository = movieRepository;
        }
    }
}