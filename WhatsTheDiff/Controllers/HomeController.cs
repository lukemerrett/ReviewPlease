using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhatsTheDiff.Models;

namespace WhatsTheDiff.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new StartReviewModel());
        }

        [HttpPost]
        public ActionResult Index(StartReviewModel startReviewModel)
        {
            if (ModelState.IsValid)
            {
                // Get PR details
            }

            return View(startReviewModel);
        }

        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}