using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AravindReddy_K_301101869.Models;

namespace AravindReddy_K_301101869.Controllers
{
    public class HomeController : Controller
    {
        IPlayerRepository repository_player;
        IClubRepository repository_club;

        public HomeController(IClubRepository club, IPlayerRepository player)
        {
            this.repository_club = club;
            this.repository_player = player;

        }
        //public ViewResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            return View("Index");
        }



    }
}