using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AravindReddy_K_301101869.Models
{
   public interface IPlayerRepository
    {
        IEnumerable<Player> playerdatafromdb { get; }

        void AddResponse(Player player);
    }
}
