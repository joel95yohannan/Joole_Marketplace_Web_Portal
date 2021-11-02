using Joole_MVC_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole_MVC.Controllers
{
    public class ProductComparisonController : Controller
    {
        IDetailRepository _iDetailRepository;
        public ProductComparisonController(IDetailRepository iDetailRepository)
        {
            _iDetailRepository = iDetailRepository;
        }
        // GET: ProductComparison
        public ActionResult Xp()
        {
            var _xp = _iDetailRepository.GetAllFans();
            return View(_xp);
        }        

        public ActionResult Xon()
        {
            var _xon = _iDetailRepository.GetAllFans();
            return View(_xon);
        }

        public ActionResult Pon()
        {
            var _pon = _iDetailRepository.GetAllFans();
            return View(_pon);
        }

        public ActionResult Xps()
        {
            var _xps = _iDetailRepository.GetAllFans();
            return View(_xps);
        }

        //toasters
        public ActionResult Sot()
        {
            var _sot = _iDetailRepository.GetAllToasters();
            return View(_sot);
        }
        public ActionResult Soh()
        {
            var _soh = _iDetailRepository.GetAllToasters();
            return View(_soh);
        }
        public ActionResult Sth()
        {
            var _sth = _iDetailRepository.GetAllToasters();
            return View(_sth);
        }
        public ActionResult Soth()
        {
            var _soth = _iDetailRepository.GetAllToasters();
            return View(_soth);
        }
        
        //vacuums
        public ActionResult Svu()
        {
            var _svu = _iDetailRepository.GetAllVacuums();
            return View(_svu);
        }
        
        public ActionResult Svw()
        {
            var _svw = _iDetailRepository.GetAllVacuums();
            return View(_svw);
        }public ActionResult Suw()
        {
            var _suw = _iDetailRepository.GetAllVacuums();
            return View(_suw);
        }public ActionResult Svuf()
        {
            var _svuf = _iDetailRepository.GetAllVacuums();
            return View(_svuf);
        }
        
    }
}