using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class MainPageController : Controller
    {
        DbTransportEntities db=new DbTransportEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        
        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialDetail()
        {
            ViewBag.leftTitle1 = "Güvenli Taşımacılık";
            ViewBag.leftTitle2 = "Dünyanın Her Yerine Tüm Kargolar";
            ViewBag.leftTitle3 = "En uzak noktalara, uzman ekibimizle ";

            ViewBag.rightTitle1 = "Taşıma Kolaylığı";
            ViewBag.rightTitle2 = "Kendi ambalajlarımız ile kargolarınızı paketliyoruz";

            ViewBag.rightTitle3 = "Şehir içi dağıtım";
            ViewBag.rightTitle4= "İstediğiniz saatte belirlediğiniz noktalara ulaştırıyoruz";

            return PartialView();
        }
        public PartialViewResult PartialScript()
        {        
            return PartialView();
        }
        public PartialViewResult PartialMap()
        {
            return PartialView();
        }
        public PartialViewResult PartialService()
        {
            ViewBag.title1 = "Biz Neler Yapıyoruz ?";
            ViewBag.title2 = "Hizmetlerimiz";

            ViewBag.leftText = "Transfer";
            ViewBag.middleText = "Canlı Destek";
            ViewBag.rightText = "Dünya Çapında Hizmet";

            return PartialView();
        }
        public PartialViewResult PartialType()
        {
            return PartialView();
        }
        public PartialViewResult PartialCommand()
        {
            return PartialView();
        }
        public PartialViewResult PartialGeneral()
        {
            return PartialView();
        }
    }
}