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
                    new Club 
                    {
                        clubName = "SoccerSorcerer", 
                        nation = "India", 
                        nWins = 20, 
                        nDraws = 4, 
                        totalPoints = 100, 
                        description = "Soccer Sorcerer is the pride of a colorful nation. Whenever they have played, they have come out of the game with flying colors. The incredible support of 1 billion people of India has supported it to win 20 titles so far. ", 
                        sponsor = "BSNL"
                    },
                    new Club 
                    { 
                        clubName = "MapleClub", 
                        nation = "Canada", 
                        nWins = 10, 
                        nDraws = 2, 
                        totalPoints = 120, 
                        description = "This is the best sooccer club in Toronto, ON, Canada. One of the best players in the world and a breakthrough start tracing back to the 1970's. A glorious history and great players makes the best in class club - Soccer Sorcerer.", 
                        sponsor = "Rogers" 
                    },
                    new Club 
                    { 
                        clubName = "AmericanClub", 
                        nation = "USA", 
                        nWins = 14, 
                        nDraws = 3, 
                        totalPoints = 80, 
                        description = "With a glorious win count of 14 so far, AmericanClub formerly known as US Soccer Club Association has been in the game since 1920s. This is one of the oldest clubs and NYC is the home to the Club since its inception.", 
                        sponsor = "Berkshire Hathaway"
                    },
                    new Club 
                    { 
                        clubName = "HechiceroFutbol", 
                        nation = "Brazil", 
                        nWins = 18, 
                        nDraws = 3, 
                        totalPoints = 100, 
                        description = "Hechicero Futbol is a champion club from Brazil. Formed in the heart of Spain - Barcelona, founder's parents moved to brazil when he was 26 and then the legacy was continued in Brazil.", 
                        sponsor = "Amancio Ortega" 
                    },
                    new Club
                    {
                        clubName = "WonderPlayers",
                        nation = "Spain",
                        nWins = 12,
                        nDraws = 2,
                        totalPoints = 95,
                        description = "Won 3 titles. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                        sponsor = "Eduardo Saverin"
                    }
                );

                context.SaveChanges();
            }
            if (!context.playeritems.Any())
            {
                context.playeritems.AddRange(
                    new Player 
                    { 
                        Name = "Shailendra Shukla", 
                        Club = "SoccerSorcerer", 
                        JersyNumber = 8, 
                        Rank = 9, 
                        totalGoals = 50 
                    },
                    new Player 
                    { 
                        Name = "Aravind Reddy", 
                        Club = "MapleClub", 
                        JersyNumber = 6, 
                        Rank = 4, 
                        totalGoals = 45 
                    },
                    new Player 
                    { 
                        Name = "Eunbi Seo", 
                        Club = "WonderPlayers", 
                        JersyNumber = 1, 
                        Rank = 5, 
                        totalGoals = 40 
                    },
                    new Player 
                    { 
                        Name = "Napster", 
                        Club = "SoccerSorcerer", 
                        JersyNumber = 12, 
                        Rank = 6, 
                        totalGoals = 10 
                    },
                    new Player
                    {
                        Name = "Messy",
                        Club = "HechiceroFutbol",
                        JersyNumber = 10,
                        Rank = 1,
                        totalGoals = 50
                    },
                    new Player
                    {
                        Name = "Ronalbo",
                        Club = "MapleClub",
                        JersyNumber = 7,
                        Rank = 1,
                        totalGoals = 50
                    },
                    new Player
                    {
                        Name = "ShailScript",
                        Club = "WonderPlayers",
                        JersyNumber = 3,
                        Rank = 13,
                        totalGoals = 10
                    },
                    new Player
                    {
                        Name = "David Beckhan",
                        Club = "AmericanClub",
                        JersyNumber = 3,
                        Rank = 2,
                        totalGoals = 48
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
