using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class ProcessController : Controller
    {
        DbTransportEntities db=new DbTransportEntities();
        public ActionResult Index()
        {
            var values = db.TblProcess.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddProcess()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProcess(TblProcess tblProcess)
        {
            db.TblProcess.Add(tblProcess);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProcess(int ID)
        {
            var value = db.TblProcess.Find(ID);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProcess(TblProcess tblProcess)
        {
            var value = db.TblProcess.Find(tblProcess.ProcessID);
            value.Transportation = tblProcess.Transportation;
            value.Description = tblProcess.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}