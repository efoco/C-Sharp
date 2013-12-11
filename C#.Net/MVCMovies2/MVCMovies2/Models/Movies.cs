using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCMovies2.Models
{
    public class Movies
    {
        public int ID { set; get;}
        public string title { set; get;}
        public DateTime ReleaseDate { set; get; }
        public string Genre { set; get; }
        public decimal Price { set; get; }
    }

    public class MovieDbContext : DbContext 
    {
        public DbSet<Movies> Movies { set; get; }
    }
}