using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AravindReddy_K_301101869.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AravindReddy_K_301101869.Controllers
{
    public class CrudController : Controller
    {
        IPlayerRepository playerrepo;
        IClubRepository clubrepo;
        ApplicationDbContext _context;

        public CrudController(ApplicationDbContext context, IPlayerRepository ipr, IClubRepository icr)
        {
            playerrepo = ipr;
            clubrepo = icr;
            _context = context;
        }


        [Authorize]
        public ActionResult EditClubForm(String clubname)
        {
            return View(_context.clubitems.Where(s => s.clubName == clubname).First());
        }

        [Authorize]
        public ActionResult EditPlayerForm(String playerName)
        {
            ViewBag.Clubs = _context.clubitems.ToList();
            return View(_context.playeritems.Where(p => p.Name == playerName).First());
        }

        [HttpPost]
        public ActionResult EditClub(Club club)
        {
            clubrepo.EditClub(club);


            return RedirectToAction("Club", "Club");
        }
        [HttpPost]
        public ActionResult EditPlayer(Player player)
        {
            playerrepo.EditPlayer(player);


            return RedirectToAction("Club", "Club");
        }

        [HttpPost]
        [Authorize]
        public ActionResult DeleteClub(String clubname)
        {
            if (ModelState.IsValid)
            {

                clubrepo.Delete(clubname);
                ModelState.Clear();
                _context.SaveChanges();
                return RedirectToAction("Club", "Club");
            }
            else
            {

                return View("ClubDetails");
            }
        }
        [HttpPost]
        [Authorize]
        public ActionResult DeletePlayer(String playerName)
        {
            if (ModelState.IsValid)
            {

                playerrepo.Delete(playerName);
                ModelState.Clear();
                _context.SaveChanges();
                return RedirectToAction("Club", "Club");
            }
            else
            {

                return View("ClubDetails");
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}