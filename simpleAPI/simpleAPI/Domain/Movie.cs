using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simpleAPI.Domain
{
    public class Movie
    {
        public int movieId { get; set; }
        public string name {get; set; }
        public string theatricalRelease {get; set; }
    }
}