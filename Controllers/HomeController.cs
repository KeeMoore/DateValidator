using Microsoft.AspNetCore.Mvc;
using DojoSurveyVal.Models;

namespace DojoSurveyVal.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new SurveyViewModel());
        }

        [HttpPost]
        public IActionResult Submit(SurveyViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = model.Name;
                ViewBag.Location = model.Location;
                ViewBag.FavoriteLanguage = model.FavoriteLanguage;
                ViewBag.Comment = model.Comment;
                ViewBag.SurveyDate = model.SurveyDate;
                return View("Result", model);
            }
            return View("Index", model);
        }

        [HttpGet]
        public IActionResult Result()
        {
            return View();
        }
    }
}
