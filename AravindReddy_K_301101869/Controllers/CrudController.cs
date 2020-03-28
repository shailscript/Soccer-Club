using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AravindReddy_K_301101869.Models;
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
        [HttpPost]
        public ActionResult EditClubForm(String clubname)
        {
            return View(_context.clubitems.Where(s => s.clubName == clubname).First());

        }
        [HttpPost]
        public ActionResult EditClub(Club club)
        {
            clubrepo.EditClub(club);
           

            return RedirectToAction("Club", "Club");
        }
        [HttpPost]
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
        public IActionResult Index()
        {
            return View();
        }
    }
}