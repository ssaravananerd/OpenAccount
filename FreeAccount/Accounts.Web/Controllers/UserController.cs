using Accounts.DAL;
using Accounts.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounts.Web.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(UserModel um)
        {
            UserDAL dal = new UserDAL();
            dal.CreateUser(um);
            return View();
        }
    }
}