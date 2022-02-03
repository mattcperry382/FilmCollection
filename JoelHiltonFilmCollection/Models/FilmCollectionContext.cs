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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            // seed the database with movie categories
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Action/Adventure"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Family"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Horror/Suspense"
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Miscellaneous"
                },
                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Television"
                },
                new Category
                {
                    CategoryId = 8,
                    CategoryName = "VHS"
                }
            );
            // seed the database with movies
            mb.Entity<FilmCollection>().HasData(
                new FilmCollection
                {
                    FilmId = 1,
                    CategoryId = 1,
                    Title = "Predator",
                    Year = "1987",
                    Director = "John McTiernan",
                    Rating = "R",
                    Edited = true
                },
                new FilmCollection
                {
                    FilmId = 2,
                    CategoryId = 1,
                    Title = "Avengers, The",
                    Year = "2012",
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = false
                },
                new FilmCollection
                {
                    FilmId = 3,
                    CategoryId = 1,
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
