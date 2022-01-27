using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHiltonFilmCollection.Models
{
    public class FilmCollectionContext : DbContext
    {
        public FilmCollectionContext(DbContextOptions<FilmCollectionContext> options) : base(options)
        {
            // leave blank
        }

        public DbSet<FilmCollection> collection { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FilmCollection>().HasData(
                new FilmCollection
                {
                    Id = 1,
                    Category = "Action/Adventure",
                    Title = "Predator",
                    Year = "1987",
                    Director = "John McTiernan",
                    Rating = "R",
                    Edited = true
                },
                new FilmCollection
                {
                    Id = 2,
                    Category = "Action/Adventure",
                    Title = "Avengers, The",
                    Year = "2012",
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = false
                },
                new FilmCollection
                {
                    Id = 3,
                    Category = "Action/Adventure",
                    Title = "Lord of the Rings: The Return of the King, The",
                    Year = "2003",
                    Director = "Peter Jackson",
                    Rating = "PG-13",
                    Edited = false
                }
            );
        }
    }
}
