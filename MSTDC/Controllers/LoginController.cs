using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAL;
using DAL;
namespace MSTDC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
       
        public ActionResult LoginC()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginC(Models.Login login)
        {
            BAL.Login data = new BAL.Login();
            data.Email = login.Email;
            data.Password = login.Password;
            LoginDAL dal = new LoginDAL();
            bool status = dal.ValidateUser(data);
            if (status)
            {
                return RedirectToAction("About");
            }
            else
            {
                return View();
            }
        }
    }
}