using Joole_MVC_Core;
using Joole_MVC_Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Joole_MVC_Infrastructure;

namespace Joole_MVC.Controllers
{
    public class LoginController : Controller
    {
        IUserRepository _iUserRepository;

        public LoginController(IUserRepository iUserRepository)
        {
            _iUserRepository = iUserRepository;
        }

        // GET: LoginPage        

        [HttpGet]
        public ActionResult LoginPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(tblUser user)
        {
            using (JooleDataBaseEntities db = new JooleDataBaseEntities())
            {

                tblUser userInfo = null;
                var userInput = user.UserName.ToString();
                bool e = userInput.Contains("@");
                if (e)
                {
                    user.UserEmail = userInput;
                    userInfo = db.tblUsers.Where(userlogin => userlogin.UserEmail == user.UserEmail && userlogin.UserPassword == user.UserPassword).FirstOrDefault();
                }
                else
                {
                    userInfo = db.tblUsers.Where(userlogin => userlogin.UserName == user.UserName && userlogin.UserPassword == user.UserPassword).FirstOrDefault();
                }

                if (userInfo == null)
                {
                    user.LoginFail = "Login fail. Please try again";
                    return View("LoginPage", user);
                }
                else
                {
                    return RedirectToAction("About", "Home");
                }
            }
        }




        public JsonResult Registration(tblUser nUser)
        {
            using (JooleDataBaseEntities sdb = new JooleDataBaseEntities())
            {
                sdb.tblUsers.Add(nUser);
                sdb.SaveChanges();
                return Json("Registration Successfull", JsonRequestBehavior.AllowGet);
            }

        }
    }
}