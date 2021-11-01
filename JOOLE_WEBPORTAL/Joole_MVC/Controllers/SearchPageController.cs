using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole_MVC.Controllers
{
    public class SearchPageController : Controller
    {
        
        // GET: SearchPage
        public ActionResult Index(string searchVal, string categoryName)
        {
            if(searchVal == null)
            {
                searchVal = "Enter a sub category";
            }
            if (searchVal.ToLower() == "fans")
            {
                return View("~/ProductSummaryController/Fans");
            }
            else if (searchVal.ToLower() == "vacuums")
            {
                return View("~/ProductSummaryController/Vacuums");
            }
            else if (searchVal.ToLower() == "toasters")
            {
                return View("~/ProductSummaryController/Toasters");
            }
            else
            {
              
                return View();

            }
        }
    }
}