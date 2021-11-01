using Joole_MVC_Core;
using Joole_MVC_Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole_MVC.Controllers
{
    public class ProductDetailController : Controller
    {        
        IDetailRepository _iDetailRepository;
        public ProductDetailController(IDetailRepository iDetailRepository)
        {
            _iDetailRepository = iDetailRepository;
        }

        // GET: ProductDetail
        public ActionResult Xfan()
        {
            var _xFan = _iDetailRepository.GetAllFans();
            return View(_xFan);
        }

        public ActionResult Profan()
        {
            var _proFan = _iDetailRepository.GetAllFans();
            return View(_proFan);
        }

        public ActionResult Sixtysevenfan()
        {
            var _ssFan = _iDetailRepository.GetAllFans();
            return View(_ssFan);
        }
        public ActionResult Svvacuum()
        {
            var _svvacuum = _iDetailRepository.GetAllVacuums();
            return View(_svvacuum);
        }
        public ActionResult Sulvacuum()
        {
            var _sulvacuum = _iDetailRepository.GetAllVacuums();
            return View(_sulvacuum);
        }
        public ActionResult Wfvacuum()
        {
            var _wfvacuum = _iDetailRepository.GetAllVacuums();
            return View(_wfvacuum);
        }
        public ActionResult Sonetoaster()
        {
            var _sonetoaster = _iDetailRepository.GetAllToasters();
            return View(_sonetoaster);
        }
        public ActionResult Stwotoaster()
        {
            var _stwotoaster = _iDetailRepository.GetAllToasters();
            return View(_stwotoaster);
        }
        public ActionResult Sthreetoaster()
        {
            var _sthreetoaster = _iDetailRepository.GetAllToasters();
            return View(_sthreetoaster);
        }

    }
}