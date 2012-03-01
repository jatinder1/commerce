using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repo = Commerce.BLL.Repository;
using BllModels = Commerce.BLL.Models;
namespace Commerce.Web.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {

            return View();
        }

    }
}
