using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MvcApplication2.Models
{
    public class Cartoon
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class CartoonDBContext : DbContext
    {
        public DbSet<Cartoon> Cartoon { get; set; }
    }
}