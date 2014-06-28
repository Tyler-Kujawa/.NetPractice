using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simpleAPI.Domain;

namespace simpleAPI.Domain.Abstract
{
    public interface IMovieRepository
    {
        IQueryable<Movie> getAll();
        Movie get(int Id);
    }
}
