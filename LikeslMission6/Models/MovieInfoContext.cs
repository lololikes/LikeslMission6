using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeslMission6.Models
{
    public class MovieInfoContext : DbContext
    {
        //Constructor
        public MovieInfoContext(DbContextOptions<MovieInfoContext> options) : base(options)
        {
        //Leave blank for now
        }
        public DbSet<MovieResponse> responses { get; set; }
        public DbSet<Category> categories { get; set; }

        // seed the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Action"},
                new Category { Id = 2, CategoryName = "Comedy"},
                new Category { Id = 3, CategoryName = "Drama" },
                new Category { Id = 4, CategoryName = "Horror" },
                new Category { Id = 5, CategoryName = "Romance" }
                );
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    Id = 1,
                    MovieName = "The Peanut Butter Falcon",
                    MovieCategoryId = 3,
                    Year = 2019,
                    Rating = "PG",
                    DirectorName = "Tyler Nilson",
                    Edited = false,
                    LentTo = null,
                    Notes = "Best Movie EVER!"
                },
                new MovieResponse
                {
                    Id = 2,
                    MovieName = "10 Things I Hate About You",
                    MovieCategoryId = 5,
                    Year = 1999,
                    Rating = "PG-13",
                    DirectorName = "Gilbert Wong",
                    Edited = true,
                    LentTo = "Abby Jensen",
                    Notes = null
                },
                new MovieResponse
                {
                    Id = 3,
                    MovieName = "Top Gun: Maverick",
                    MovieCategoryId = 1,
                    Year = 2022,
                    Rating = "PG-13",
                    DirectorName = "Joseph Kosinski",
                    Edited = false,
                    LentTo = null,
                    Notes = "A thrill!!"
                }
           
                );
        }
    }
}
