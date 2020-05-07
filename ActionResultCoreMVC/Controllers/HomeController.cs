using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ActionResultCoreMVC.Models;
using Microsoft.AspNetCore.Components;
using ActionResultCoreMVC.Data;

namespace ActionResultCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ViewResult ViewResult()
        {
            return View("About","Home");
        }

        public JsonResult JsonResult()
        {
            var employee = db.Employees.ToList();
            return Json(new { data=employee});
        }

        public ContentResult ContentResult()
        {
            return Content("I am ContentResult");
        }
        public PartialViewResult PartialViewResult()
        {
            var employee = db.Employees.ToList();
            return PartialView("_PartialView",employee);
        }

        public EmptyResult EmptyResult()
        {
            return new EmptyResult();
        }

        public ViewComponent ViewComponent()
        {
            return ViewComponent();
        }

        public ChallengeResult ChallengeResult()
        {
            return new ChallengeResult();
        }
    }
}
