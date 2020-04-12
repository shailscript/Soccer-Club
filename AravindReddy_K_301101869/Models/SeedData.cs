using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AravindReddy_K_301101869.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.clubitems.Any())
            {
                context.clubitems.AddRange(
                new Club { clubName = "SoccerLions", nation = "india", nWins = 10, nDraws = 4, totalPoints = 100, description = "won 3 titles", sponsor = "bsnl" },
                new Club { clubName = "Socceeerr", nation = "canada", nWins = 11, nDraws = 2, totalPoints = 120, description = "won 5 titles", sponsor = "Rogers" },
                new Club { clubName = "TorontoClub", nation = "canada", nWins = 8, nDraws = 3, totalPoints = 80, description = "won 2 titles", sponsor = "Henna" },
                new Club { clubName = "NewTorontoClub", nation = "canada", nWins = 8, nDraws = 3, totalPoints = 80, description = "won 2 titles", sponsor = "Henna" }

              );
                context.SaveChanges();
            }
            if (!context.playeritems.Any())
            {
                context.playeritems.AddRange(
                    new Player { Name = "Aravind", Club = "SoccerLions", JersyNumber = 2, Rank = 1, totalGoals = 50 },
                    new Player { Name = "Reddy", Club = "Socceeerr", JersyNumber = 5, Rank = 7, totalGoals = 30 },
                    new Player { Name = "Komat", Club = "SoccerLions", JersyNumber = 1, Rank = 17, totalGoals = 20 },
                    new Player { Name = "Anil", Club = "TorontoClub", JersyNumber = 3, Rank = 21, totalGoals = 10 }
                  );
                context.SaveChanges();
            }



        }
    }
}
