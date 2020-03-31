using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AravindReddy_K_301101869.Models;
using AravindReddy_K_301101869.Models.ViewModels;
using AravindReddy_K_301101869;
using Microsoft.AspNetCore.Authorization;

namespace AravindReddy_K_301101869.Controllers
{
    public class ClubController : Controller
    {
        private IClubRepository clubRepository;
        private IPlayerRepository playerRepository;

        public ClubController(IClubRepository crepo,IPlayerRepository prepo)
        {
            clubRepository = crepo;
            playerRepository = prepo;
        }

        [HttpGet]
        [Authorize]
        public ViewResult AddClub()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult AddClub(Club clubs)
        {
            clubRepository.AddClub(clubs);
            ModelState.Clear();
            return RedirectToAction("Club", "Club");
        }

        public ViewResult Club()
        {
            return View(clubRepository.clubfromdb);
        }

        [HttpGet]
        public ViewResult ClubDetails(string clubName )
        {
            //return View(clubRepository.clubfromdb.Where(club=>club.clubName==clubName));

           return View( new PlayerClubViewModel
          {
               club = clubRepository.clubfromdb.Where(c => c.clubName == clubName),
              player = playerRepository.playerdatafromdb.Where(p => p.Club == clubName)
           });
        }
    }
}