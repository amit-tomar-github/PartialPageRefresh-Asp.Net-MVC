using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialPageRefresh.Controllers
{
    public class HomeController : Controller
    {
        List<string> countries = new List<string>();
        public HomeController()
        {
            countries.Add("USA");
            countries.Add("UK");
            countries.Add("India");
        }  
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetPartial()
        {
            return PartialView("_CountriesPartial", countries);
        }
        public ActionResult GetSelectedPartial(string selectedCountry)
        {
            var finalCount = countries.FindAll(x=>x.Contains(selectedCountry));
            return PartialView("_CountriesPartial", finalCount);
        }
    }
}