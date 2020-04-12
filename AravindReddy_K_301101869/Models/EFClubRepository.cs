using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AravindReddy_K_301101869.Models
{
    public class EFClubRepository : IClubRepository
    {
        private ApplicationDbContext context;

        public EFClubRepository(ApplicationDbContext ctx) { context = ctx; }
        public IQueryable<Club> clubsdatafromdb => context.clubitems;







        IEnumerable<Club> IClubRepository.clubfromdb => context.clubitems;



        public void Delete(String nameofclub)
        {

            Club club = context.clubitems.Where(c => c.clubName == nameofclub).FirstOrDefault();
            context.clubitems.Remove(club);
            context.SaveChanges();
        }

        public void AddClub(Club newClub)
        {

            context.clubitems.Add(newClub);
            context.SaveChanges();
        }

        public void EditClub(Club club)
        {
            Club editclub = context.clubitems.Where(s => s.clubName == club.clubName).First();
            editclub.clubName = club.clubName;
            editclub.nation = club.nation;
            editclub.nWins = club.nWins;
            editclub.nDraws = club.nDraws;
            editclub.totalPoints = club.totalPoints;
            editclub.description = club.description;
            editclub.sponsor = club.sponsor;
            context.SaveChanges();
        }
    }
}
