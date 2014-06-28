using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using simpleAPI.Domain;

namespace simpleAPI.Domain.Concrete
{
    public class EfDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}