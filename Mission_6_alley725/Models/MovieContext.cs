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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movies>().HasData(
                new Movies
                {
                    movieId = 1,
                    title = "Invincible",
                    rating = "PG",
                    category = "Sports",
                    year = 2006,
                    edited = false,
                    lentTo = "",
                    notes = "My all-time favorite"
                },
                new Movies
                {
                    movieId = 2,
                    title = "Tommy Boy",
                    rating = "PG-13",
                    category = "Comedy",
                    year = 1995,
                    edited = false,
                    lentTo = "",
                    notes = ""
                },
                new Movies
                {
                    movieId = 3,
                    title = "Top Gun: Maverick",
                    rating = "PG-13",
                    category = "Action",
                    year = 2022,
                    edited = false,
                    lentTo = "",
                    notes = ""
                }

            );
        }

    }
}
