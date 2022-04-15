using Microsoft.AspNetCore.Mvc;
using RestoSiteASP.NetCore_MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoSiteASP.NetCore_MVC.Controllers
{
    public class TeamController : Controller
    {
        private IRepository _repo;

        public TeamController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
        public IActionResult GoAbout()
        {
            return RedirectToAction("Index", "About");
        }
        public IActionResult GoSpecialDishes()
        {
            return RedirectToAction("Index", "SpecialDishes");
        }
        public IActionResult GoMenu()
        {
            return RedirectToAction("Index", "Menu");
        }
        public IActionResult GoTeam()
        {
            return RedirectToAction("Index", "Team");
        }
    }
}
