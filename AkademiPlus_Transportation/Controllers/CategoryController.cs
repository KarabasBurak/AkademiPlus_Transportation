using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class CategoryController : Controller
    {
        DbTransportEntities db=new DbTransportEntities();
        public ActionResult Index()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory() 
        
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(TblCategory tblCategory)
        {
            db.TblCategory.Add(tblCategory);
            db.SaveChanges();
            return View();
        }
        public ActionResult DeleteCategory(int ID)
        {
            var value = db.TblCategory.Find(ID);
            db.TblCategory.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int ID) 
        {
        var value=db.TblCategory.Find(ID);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TblCategory tblCategory)
        {
            var value = db.TblCategory.Find(tblCategory.CategoryID);
            value.CategoryName = tblCategory.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}