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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    ApplicatioId = 1,
                    MovieName = "The Peanut Butter Falcon",
                    Category = "Adventure/Drama",
                    Year = 2019,
                    Rating = "PG",
                    DirectorName = "Tyler Nilson",
                    Edited = false,
                    LentTo = null,
                    Notes = "Best Movie EVER!"
                },
                new MovieResponse
                {
                    ApplicatioId = 2,
                    MovieName = "10 Things I Hate About You",
                    Category = "Romance/Comedy",
                    Year = 1999,
                    Rating = "PG-13",
                    DirectorName = "Gilbert Wong",
                    Edited = true,
                    LentTo = "Abby Jensen",
                    Notes = null
                },
                new MovieResponse
                {
                    ApplicatioId = 3,
                    MovieName = "Top Gun: Maverick",
                    Category = "Action/Adventure",
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
