using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AravindReddy_K_301101869.Models;
using Microsoft.AspNetCore.Authorization;
using AravindReddy_K_301101869.Models.ViewModels;

namespace AravindReddy_K_301101869.Controllers
{
    public class PlayersController : Controller
    {
        IPlayerRepository playerRepository;
        private ApplicationDbContext dbContext;
        public PlayersController(IPlayerRepository repository, ApplicationDbContext applicationDbContext)
        {

            this.playerRepository = repository;
            this.dbContext = applicationDbContext;

        }
        [HttpGet]
        [Authorize]
        public ViewResult AddPlayer()
        {
            ViewBag.Clubs = dbContext.clubitems.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult AddPlayer(Player player)
        {

            if (ModelState.IsValid)
            {
                playerRepository.AddResponse(player);
                ModelState.Clear();
                return RedirectToAction(nameof(ManagePlayers));
            }
            else
            {
                return View();
            }
        }
        public int PageSize = 2;

        public ViewResult ManagePlayers(int productPage = 1)
        {
            return View(new PlayerClubViewModel
            {

                player = playerRepository.playerdatafromdb
                    .OrderBy(p => p.Name).Skip((productPage - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = playerRepository.playerdatafromdb.Count()

                }
            }
                );
        }

    }
}
