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
    }
}
