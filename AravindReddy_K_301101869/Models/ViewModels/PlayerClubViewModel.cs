using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AravindReddy_K_301101869.Models.ViewModels
{
    public class PlayerClubViewModel
    {
        public IEnumerable<Club> club { get; set; }
        public IEnumerable<Player> player { get; set; }
    }
}
