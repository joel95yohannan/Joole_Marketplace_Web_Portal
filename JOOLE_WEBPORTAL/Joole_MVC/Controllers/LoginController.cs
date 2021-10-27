using Joole_MVC_Core;
using Joole_MVC_Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole_MVC.Controllers
{
    public class LoginController : Controller
    {
        IUserRepository _iUserRepository;

        public LoginController(IUserRepository iUserRepository)
        {
            _iUserRepository = iUserRepository;
        }

        // GET: Login
        public ActionResult Login()
        {
            var _lstUsers = _iUserRepository.GetAllUsers();
            return View(_lstUsers);
        }
    }
}