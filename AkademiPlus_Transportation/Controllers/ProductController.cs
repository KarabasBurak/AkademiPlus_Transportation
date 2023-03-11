using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class ProductController : Controller
    {
        DbTransportEntities db=new DbTransportEntities();
        public ActionResult Index()
        {
            var values=db.TblProduct.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in db.TblCategory
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(TblProduct tblProduct)
        {
            
            db.TblProduct.Add(tblProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteProduct(int ID)
        {
            var value = db.TblProduct.Find(ID);
            db.TblProduct.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProduct(int ID)
        {
            var value = db.TblProduct.Find(ID);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProduct(TblProduct tblProduct)
        {
            var value = db.TblProduct.Find(tblProduct.ProductID);
            value.ProductName = tblProduct.ProductName;
            value.ProductSizeType = tblProduct.ProductSizeType;
            value.ProductSize = tblProduct.ProductSize;          
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}