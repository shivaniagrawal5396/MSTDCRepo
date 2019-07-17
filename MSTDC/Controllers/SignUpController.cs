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
            s.Name = newuser.Name;
            s.Email = newuser.Email;
            s.Password = newuser.Password;
            s.Gender = newuser.Gender;
            s.DOB = newuser.DOB;
            DAL.LoginDAL dal = new LoginDAL();
            bool status = dal.SignUp(s);
            if (status)
            {
                return RedirectToAction("LoginC", "Login");
            }

            return View();
            
        }
    }
}