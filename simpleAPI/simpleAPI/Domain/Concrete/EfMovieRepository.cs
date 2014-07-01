using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using simpleAPI.Domain.Abstract;
using simpleAPI.Domain.Concrete;

namespace simpleAPI.Domain.Concrete
{
    public class EfMovieRepository : IMovieRepository
    {
        private EfDbContext _dbContext = new EfDbContext();

        public IQueryable<Movie> getAll() 
        {
            return _dbContext.Movies;
        }

        public Movie get(int movieId) 
        {
            return _dbContext.Movies
                .Where(i => i.movieId == movieId)
                .FirstOrDefault();
        }
    }
}