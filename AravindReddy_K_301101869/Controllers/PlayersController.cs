using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AravindReddy_K_301101869.Models;
using Microsoft.AspNetCore.Authorization;

namespace AravindReddy_K_301101869.Controllers
{
    public class PlayersController : Controller
    {
        IPlayerRepository iRepositoryPlayer;
        
        public PlayersController( IPlayerRepository iPlayerRepo)
        {
           
            this.iRepositoryPlayer = iPlayerRepo;

        }
        [HttpGet]
        public ViewResult AddPlayer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPlayer(Player player)
        {

            if (ModelState.IsValid)
            {
               iRepositoryPlayer.AddResponse(player); 
                ModelState.Clear(); 
                return View();
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        public ViewResult ManagePlayers()
        {
            return View(iRepositoryPlayer.playerdatafromdb);
        }
    }
}