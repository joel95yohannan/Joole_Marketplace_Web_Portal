using Joole_MVC_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole_MVC.Controllers
{
    public class ProductSummaryController : Controller
    {
        IProductRepository iProductRepository;

        public ProductSummaryController(IProductRepository _iProductRepository)
        {
            iProductRepository = _iProductRepository;
        }
        // GET: ProductSummary
        public ActionResult Fans()
        {
            var _productList = iProductRepository.GetFans();
            return View(_productList);
        }
        public ActionResult Vacuums()
        {
            var _productList = iProductRepository.GetVacuums();
            return View(_productList);
        }
        public ActionResult Toasters()
        {
            var _productList = iProductRepository.GetToasters();
            return View(_productList);
        }
    }
}