using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BooksMVC.Models
{
    public class Books
    {
        public int ID { get; set;}
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DatePublished { get; set;}
        public string Genre { get; set; }

    }

    public class BookDbContext : DbContext
    { 
        public DbSet<Books> Books { get; set;}
    }
}