using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAL;
using DAL;
namespace MSTDC.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
      
        public ActionResult SignUpC()
        {

            return View();
        }
        [HttpPost]
        public ActionResult SignupC(Models.Signup newuser)
        {
            BAL.Signup s = new BAL.Signup();
            s.Email = newuser.Email;
            s.Name = newuser.Name;
            DAL.LoginDAL dal = new LoginDAL();
            bool ans = dal.SignUp(s);
            return View();
        }
    }
}