using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using simpleAPI.Domain;
using simpleAPI.Domain.Abstract;

namespace simpleAPI.Domain.Concrete
{
    public class MovieRepository : IMovieRepository
    {
        public IQueryable<Movie> getAll() 
        {
            return null;
        }

        public Movie get(int Id) 
        {
            return null;
        }
    }
}