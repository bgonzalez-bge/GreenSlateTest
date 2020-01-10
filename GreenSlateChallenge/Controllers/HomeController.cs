using GreenSlateChallenge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreenSlateChallenge.Controllers
{
    public class HomeController : Controller
    {
        DataService _dataService;
       
        public HomeController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Users = _dataService.GetAllUsers();
            return View();
        }

        [HttpGet]
        public JsonResult GetProjects(int userId)
        {
            var Projects = _dataService.GetProjectsByUser(userId);
            return Json(Projects, JsonRequestBehavior.AllowGet);
        }

    }
}