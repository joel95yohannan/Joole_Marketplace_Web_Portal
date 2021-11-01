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
            if (searchVal == null || categoryName == null)
            {
                searchVal = "Enter a sub category";
            }
            if (searchVal.ToLower() == "fans" && categoryName.ToLower() == "mechanical")
            {
                return RedirectToAction("Fans","ProductSummary");
            }
            else if (searchVal.ToLower() == "vacuums" && categoryName.ToLower() == "mechanical")
            {
                return RedirectToAction("Vacuums", "ProductSummary");
            }
            else if (searchVal.ToLower() == "toasters" && categoryName.ToLower() == "mechanical")
            {
                return RedirectToAction("Toasters", "ProductSummary");
            }
            else
            {

                return View();

            }
        }
    }
}