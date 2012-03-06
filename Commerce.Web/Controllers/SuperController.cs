using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repo = Commerce.BLL.Repository;
using BllModels = Commerce.BLL.Models;
using Commerce.Web.Controllers;
using Commerce.BLL.Models;
using System.Web.Security;


namespace Commerce.Web.Controllers
{
    public class SuperController : Controller
    {
        
        //// GET: /Super/

        public ActionResult index()
        {
            BllModels.User user = Repo.Super.GetSuperUser();
            return View();
        }

        public ActionResult AddNewUser(User user)
        {
            Repo.Super.CreateSuperUser(user);
            return View();
        }

      
    }
}

