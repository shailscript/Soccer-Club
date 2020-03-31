using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AravindReddy_K_301101869.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AravindReddy_K_301101869.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IClubRepository repository;
        public AdminController(IClubRepository repo) { repository = repo; }
        public ViewResult Index() => View(repository.clubfromdb);
    }
}