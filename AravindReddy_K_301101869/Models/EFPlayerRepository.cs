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
    }
    }
