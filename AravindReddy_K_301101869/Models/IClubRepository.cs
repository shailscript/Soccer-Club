using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AravindReddy_K_301101869.Models
{
   public interface IClubRepository
    {
      

        IEnumerable<Club> clubfromdb  { get; }
        void AddClub(Club newCLub);
        void Delete(String clubname);
        void EditClub(Club club);
    }
}
