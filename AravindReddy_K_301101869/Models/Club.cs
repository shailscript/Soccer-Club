using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AravindReddy_K_301101869.Models
{
    public class Club
    {
        [Key]
        public string clubName { set; get; }
        public string nation { set; get; }
        
        public int? nWins { get; set; }
       
        public int? nDraws { get; set; }
        public int? totalPoints { get; set; }
        public string description { set; get; }
        public string sponsor { set; get; }
    }
}
