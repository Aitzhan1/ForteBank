using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weather.Models;

namespace Weather.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Weather()
        {
            return View();
        }
        public JsonResult GetWeather()
        {
            Models.Weather weath = new Models.Weather();
            return Json(weath.getWeatherForcast(), JsonRequestBehavior.AllowGet);
        }
    }
}