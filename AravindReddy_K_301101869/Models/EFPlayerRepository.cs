using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AravindReddy_K_301101869.Models
{
    public class EFPlayerRepository : IPlayerRepository
    {
        private ApplicationDbContext context;

        public EFPlayerRepository(ApplicationDbContext ctx) { context = ctx; }
        IEnumerable<Player> IPlayerRepository.playerdatafromdb => context.playeritems;

        public void AddResponse(Player player)
        {
            context.playeritems.Add(player);
            context.SaveChanges();
        }

        public void Delete(String PlayerName)
        {
            Player player = context.playeritems.Where(p => p.Name == PlayerName).FirstOrDefault();
            context.playeritems.Remove(player);
            context.SaveChanges();
        }

        public void EditPlayer(Player player)
        {
            Player editplayer = context.playeritems.Where(p => p.Name == player.Name).First();
            editplayer.Name = player.Name;
            editplayer.Club = player.Club;
            editplayer.JersyNumber = player.JersyNumber;
            editplayer.Rank = player.Rank;
            editplayer.totalGoals = player.totalGoals;

            context.SaveChanges();
        }
    }
}
