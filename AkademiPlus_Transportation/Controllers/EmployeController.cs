using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class EmployeController : Controller
    {
        DbTransportEntities db=new DbTransportEntities();
        public ActionResult Index()
        {
            var values = db.TblEmploye.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddEmploye()
        {
            return View();
        }
        [HttpPost]

        public ActionResult AddEmploye(TblEmploye tblEmploye)
        {
            db.TblEmploye.Add(tblEmploye);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteEmploye(int ID)
        {
            var value = db.TblEmploye.Find(ID);
            db.TblEmploye.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]

        public ActionResult UpdateEmploye(int ID)
        {
            var value = db.TblEmploye.Find(ID);
            return View(value);
        }

        [HttpPost]

        public ActionResult UpdateEmploye(TblEmploye tblEmploye)
        {
            var value = db.TblEmploye.Find(tblEmploye.EmployeID);
            value.EmployeName = tblEmploye.EmployeName;
            value.EmployeSurname = tblEmploye.EmployeSurname;
            value.Employeİmage = tblEmploye.Employeİmage;
            value.EmployeDescription = tblEmploye.EmployeDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}