using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ActionResultCoreMVC.Models;
using Microsoft.AspNetCore.Components;

namespace ActionResultCoreMVC.Controllers
{
    public class HomeController : Controller
    {
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
            var name = "Farhan Ahmed";
            return Json(new { data=name});
        }

        public ContentResult ContentResult()
        {
            return Content("I am ContentResult");
        }
        public PartialViewResult PartialViewResult()
        {
            return PartialView("_PartialView");
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
