﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVeator.Entities;
using CVeatorServices;

namespace CVeator.Web.Controllers
{
    public class CVsController : Controller
    {
        CVsServices cvServices = new CVsServices();
        public ActionResult Index()
        {
            //PersonalInfo personalInfo = new PersonalInfo();

            var AllCVs = cvServices.GetAllCVs();
            return View(AllCVs);
        }
        
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(PersonalInfo personalInfo)
        {
            int id= cvServices.SaveCV(personalInfo);
            return RedirectToAction("create", "Experiences", new {CvID = id });
        }

        public ActionResult Edit(int ID)
        {
           var cv = cvServices.GetCVById(ID);
            return View(cv);
        }
        [HttpPost]
        public ActionResult Edit(PersonalInfo personalInfo)
        {
            cvServices.UpdateCV(personalInfo);
            return RedirectToAction("index");
        }
        //public ActionResult Delete(int ID)
        //{
        //    var CV = cvServices.GetCVById(ID);
        //    return View(CV);
        //    //return PartialView(auction);
        //}
        [HttpPost]
        public ActionResult Delete(PersonalInfo personalInfo)
        {
            cvServices.DeleteCV(personalInfo);
            return RedirectToAction("index");
        }
    }
}