using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simpleAPI.Domain.Concrete
{
    public class EFMovieContext : EfDbContext
    {
        private EfDbContext context = new EfDbContext();

        public IQueryable<Movie> Movies { get
            { return context.Movies; } 
        }
    }
}