using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repo = Commerce.BLL.Repository;
using BllModels = Commerce.BLL.Models;
using Commerce.Web.Controllers;
using Commerce.BLL.Models;

namespace Commerce.Web.Controllers
{
    public class SuperController : Controller
    {
        //
        // GET: /Super/

        public ActionResult Index()
        {
            BllModels.User user = Repo.Super.CreateSuperUser();
            return View();
        }
       
        }
   }

