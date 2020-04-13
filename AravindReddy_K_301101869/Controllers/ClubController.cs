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

        public ClubController(IClubRepository crepo, IPlayerRepository prepo)
        {
            clubRepository = crepo;
            playerRepository = prepo;
        }
        [Authorize]
        [HttpGet]
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

        public int PageSize = 3;
        public ViewResult Club(int productPage = 1)
        {
            return View(new PlayerClubViewModel
            {
                club = clubRepository.clubfromdb.OrderBy(c => c.clubName)
                                                .Skip((productPage - 1) * PageSize)
                                                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = clubRepository.clubfromdb.Count()
                }
            });

        }

        [HttpGet]
        public ViewResult ClubDetails(string clubName, int productPage = 1)
        {
            return View(new PlayerClubViewModel
            {
                club = clubRepository.clubfromdb.Where(c => c.clubName == clubName),
                player = playerRepository.playerdatafromdb.Where(p => p.Club == clubName)
            });
        }
    }
}