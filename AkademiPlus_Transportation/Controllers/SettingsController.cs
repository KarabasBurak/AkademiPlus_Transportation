using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class SettingsController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        [HttpGet]
        public ActionResult Index()
        {
            var values = Session["UserName"];
            var userValue= db.Tbl_Admin.Where(x => x.UserName==values).FirstOrDefault();
            return View(userValue);
        }
        [HttpPost]
        public ActionResult Index(Tbl_Admin tbl_Admin)
        {
            return View();
        }
    }
}