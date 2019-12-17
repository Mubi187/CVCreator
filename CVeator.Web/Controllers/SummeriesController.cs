using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVeator.Entities;
using CVeator.Web.ViewModels;
using CVeatorServices;

namespace CVeator.Web.Controllers
{
    public class SummeriesController : Controller
    {
        SummeriesServices SummeriesServices = new SummeriesServices();
        public ActionResult Index()
        {
            var AllSummery = SummeriesServices.GetAllSummeries();
            return View(AllSummery);
        }

        
        public ActionResult Create(int CvID)
        {
            SummeriesViewModel model = new SummeriesViewModel();
            model.PersonalInfo_ID= CvID;
            return View(model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(Summery Summery)
        {
            SummeriesServices.SaveSummery(Summery);
            return RedirectToAction("CV1","CVsView/1");
        }

        public ActionResult Edit(int ID)
        {
           var Summery = SummeriesServices.GetSummeryById(ID);
            return View(Summery);
        }
        [HttpPost]
        public ActionResult Edit(Summery Summery)
        {
            SummeriesServices.UpdateSummery(Summery);
            return RedirectToAction("index");
        }
        //public ActionResult Delete(int ID)
        //{
        //    var CV = cvServices.GetCVById(ID);
        //    return View(CV);
        //    //return PartialView(auction);
        //}
        [HttpPost]
        public ActionResult Delete(Summery Summery)
        {
            SummeriesServices.DeleteSummery(Summery);
            return RedirectToAction("index");
        }
    }
}