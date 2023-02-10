using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_6_alley725.Models
{
    public class MovieContext  : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options){

        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Ratings>().HasData(
                new Ratings
                {
                    ratingId = 1,
                    rating = "G"
                },
                new Ratings
                {
                    ratingId = 2,
                    rating = "PG"
                },
                new Ratings
                {
                    ratingId = 3,
                    rating = "PG-13"
                },
                new Ratings
                {
                    ratingId = 4,
                    rating = "R"
                }

            );

            mb.Entity<Category>().HasData(
                new Category
                {
                    categoryId = 1,
                    category = "Action/Adventure"
                },
                new Category
                {
                    categoryId = 2,
                    category = "Comedy"
                },
                new Category
                {
                    categoryId = 3,
                    category = "Sports"
                },
                new Category
                {
                    categoryId = 4,
                    category = "Drama"
                },
                new Category
                {
                    categoryId = 5,
                    category = "Family"
                },
                new Category
                {
                    categoryId = 6,
                    category = "Horror/Suspense"
                },
                new Category
                {
                    categoryId = 7,
                    category = "Miscellaneous"
                },
                new Category
                {
                    categoryId = 8,
                    category = "Television"
                },
                new Category
                {
                    categoryId = 9,
                    category = "VHS"
                }
            );

            mb.Entity<Movies>().HasData(
                new Movies
                {
                    movieId = 1,
                    title = "Invincible",
                    ratingId = 2,
                    categoryId = 3,
                    year = 2006,
                    edited = false,
                    lentTo = "",
                    notes = "My all-time favorite"
                },
                new Movies
                {
                    movieId = 2,
                    title = "Tommy Boy",
                    ratingId = 3,
                    categoryId = 2,
                    year = 1995,
                    edited = false,
                    lentTo = "",
                    notes = ""
                },
                new Movies
                {
                    movieId = 3,
                    title = "Top Gun: Maverick",
                    ratingId = 3,
                    categoryId = 1,
                    year = 2022,
                    edited = false,
                    lentTo = "",
                    notes = ""
                }

            );
        }

    }
}
